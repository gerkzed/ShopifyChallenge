using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShopifyChallenge
{

    public partial class mainfrm : Form

    {


        
        public string datadir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"PhotoRepository\");
        
        
        public Image image;
        public mainfrm()
        {

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                Directory.CreateDirectory(datadir);
                Directory.CreateDirectory(datadir + "pictures");
                

                if (File.Exists(datadir + "pics.txt"))
                {

                }

                else
                {

                    // Create a new file     
                    using (FileStream fs = File.Create(datadir + "pics.txt"))
                    {
                        Console.WriteLine("textfile created");
                    }

                }
            


            InitializeComponent();

            BuildListView();
            FillListView();
            InitializePictureBox();
            
        }
        private void BuildListView()
        {

            string[] pics2 = RefreshData();

            if (pics2.Length == 0)
            {
                if (MessageBox.Show("No photo's detected, click OK to begin adding", "Add Photo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    FirstPhoto();
                }
            }
                
                

                ColumnHeader header1, header2;
                header1 = new ColumnHeader();
                header2 = new ColumnHeader();

                header1.Text = "File name";
                header1.TextAlign = HorizontalAlignment.Left;
                header1.Width = -1;

                header2.TextAlign = HorizontalAlignment.Left;
                header2.Text = "Location";
                header2.Width = -1;

                ListView1.Columns.Add(header1);
                ListView1.Columns.Add(header2);
                ListView1.View = View.Details;
            }
        
        private string [] RefreshData()
        {
            string[] pics1 = File.ReadAllLines(datadir + "pics.txt");
            return pics1;
        }
        private void FillListView()
        {
            string[] pics2 = RefreshData();

            if (pics2 != null)
            {
                foreach (string pic in pics2)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(pic));
                    item.SubItems.Add(pic);
                    ListView1.Items.Add(item);
                }
            }
        }

        private void InitializePictureBox()
        {
           
            this.PictureBox1.TabStop = false;
            this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureBox1.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(this.PictureBox1);
        }

        private void MoveImage(string dir, string name)
        {

            File.Copy(dir, datadir + @"pictures\" + name, true);

        }

        private void ListView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (image != null)
            {
                PictureBox1.Image = null;
                image.Dispose();
            }

            try
            {
                ListViewItem selection = ListView1.GetItemAt(e.X, e.Y);
                if (selection != null)
                {
                    image = Image.FromFile(selection.SubItems[1].Text);

                    PictureBox1.Image = image;

                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);


            }
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = ListView1.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    contextMenuStrip2.Show(ListView1, e.Location);
                }
            }
        }


        private void FirstPhoto()
        {

            var dup = false;
            var pics1 = RefreshData();
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select An Image(s)";
            openDialog.Multiselect = true;
            openDialog.Filter = "Image Files (*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG)|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                for (int i = 0; i < pics1.Length; i++)
                {
                    if (datadir + openDialog.SafeFileName == pics1[i])
                    {
                        MessageBox.Show("This image is already in your repository.", "Duplicate Photo", MessageBoxButtons.OK);
                        dup = true;
                        break;
                    }


                }
                if (dup == false)
                {
                    string[] files = openDialog.FileNames;
                    string[] safenames = openDialog.SafeFileNames;

                    for (int i = 0; i < files.Length; i++)
                    {
                        StreamWriter sw = new StreamWriter(datadir + "pics.txt", true);

                        sw.WriteLine(datadir + @"pictures\" + safenames[i]);

                        MoveImage(files[i], safenames[i]);

                        sw.Close();
                    }
                }

            }
        }

        private void addPhotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var pics1 = RefreshData();
            var dup = false;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;
            openDialog.Title = "Select An Image(s)";
            openDialog.Filter = "Image Files (*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG)|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                for (int i = 0; i < pics1.Length; i++)
                {
                    if (datadir + openDialog.SafeFileName == pics1[i])
                    {
                        MessageBox.Show("This image is already in your repository.", "Duplicate Photo", MessageBoxButtons.OK);
                        dup = true;
                        break;
                    }


                }

                if (dup == false)
                {
                    string[] files = openDialog.FileNames;
                    string[] safenames = openDialog.SafeFileNames;

                    for(int i = 0; i < files.Length; i++)
                    {
                        StreamWriter sw = new StreamWriter(datadir + "pics.txt", true);

                        sw.WriteLine(datadir + @"pictures\" + safenames[i]);

                        MoveImage(files[i], safenames[i]);

                        sw.Close();

                        ListView1.Items.Clear();
                        FillListView();
                        pics1 = RefreshData();
                    }
                }
                

            }
        }

        private void deletePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string[] pics3 = RefreshData();
            if (MessageBox.Show("Are you sure you want to delete " + ListView1.FocusedItem.Text, "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                image.Dispose();

                for (int i = 0; i < pics3.Length; i++)
                {

                    if (ListView1.FocusedItem.SubItems[1].Text == pics3[i])
                    {

                        List<string> linesList = File.ReadAllLines(datadir + "pics.txt").ToList();
                        linesList.RemoveAt(i);
                        File.WriteAllLines((datadir + "pics.txt"), linesList.ToArray());

                        ListView1.Items.Clear();
                        PictureBox1.Image = null;
                        FillListView();

                        if (File.Exists(pics3[i]))
                        {

                            try
                            {
                                PictureBox1.Image = null;
                                image.Dispose();
                                File.Delete(pics3[i]);
                            }
                            catch (IOException ea)
                            {

                                Console.WriteLine(ea.Message);
                                return;
                            }
                        }
                        break;
                    }
                }
            }
            else
            {

            }


        }

        private void viewFullsizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.AutoSize = true;
            form.MinimumSize = new Size(image.Width, image.Height);
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            form.Controls.Add(pictureBox);

            form.ShowDialog();
        }
    }
}
