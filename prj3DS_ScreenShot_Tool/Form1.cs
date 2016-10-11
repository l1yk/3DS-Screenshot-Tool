using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj3DS_ScreenShot_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DriveInfo> LstRemovableDrives = new List<DriveInfo>();
            List<string> LstValidScreenshotFiles = new List<string>();

            foreach (DriveInfo tmpDrive in DriveInfo.GetDrives())
            {
                if (!tmpDrive.Name.Equals(@"A:\"))
                {
                    if (tmpDrive.DriveType.Equals(DriveType.Removable))
                    {
                        LstRemovableDrives.Add(tmpDrive);
                    }
                }
            }

            foreach (DriveInfo tmpDrive in LstRemovableDrives)
            {
                DirectoryInfo tmpDirInfo = new DirectoryInfo(tmpDrive.Name);
                List<FileInfo> tmpBmpFileList = new List<FileInfo>();
                tmpBmpFileList.AddRange(tmpDirInfo.GetFiles("*.bmp", SearchOption.TopDirectoryOnly));
                foreach (FileInfo tmpFileInfo in tmpBmpFileList)
                {
                    if (tmpFileInfo.Name.IndexOf("top_").Equals(0))
                    {
                        if (File.Exists(tmpDirInfo.FullName + tmpFileInfo.Name.Replace("top_", "bot_")))
                        {
                            LstValidScreenshotFiles.Add(tmpDirInfo.Name + tmpFileInfo.Name);
                        }
                    }
                }
            }

            if (LstValidScreenshotFiles.Count > 0)
            {
                picTopScreen.Image = Image.FromFile(LstValidScreenshotFiles[LstValidScreenshotFiles.Count - 1]);
                picBottomScreen.Image = Image.FromFile(LstValidScreenshotFiles[LstValidScreenshotFiles.Count - 1].Replace("\\top_", "\\bot_"));
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Bitmap picRslt;
            if (picTopScreen.Image != null && picBottomScreen.Image != null)
            {
                picRslt = (Bitmap)MergeScreenshot(picTopScreen.Image, picBottomScreen.Image);
            }
            else
            {
                if (picTopScreen.Image != null & picBottomScreen.Image == null)
                {
                    Bitmap bitTopScreen = (Bitmap)picTopScreen.Image;
                    Bitmap bitBlack = new Bitmap(320, 240);
                    bitBlack.SetResolution(bitTopScreen.HorizontalResolution, bitTopScreen.VerticalResolution);
                    using (Graphics gr = Graphics.FromImage(bitBlack))
                    {
                        gr.Clear(Color.Black);
                    }
                    picRslt = (Bitmap)MergeScreenshot(bitTopScreen, bitBlack);
                }
                else if (picTopScreen.Image == null & picBottomScreen.Image != null)
                {
                    Bitmap bitBottomScreen = (Bitmap)picTopScreen.Image;
                    Bitmap bitBlack = new Bitmap(400, 240);
                    bitBlack.SetResolution(bitBottomScreen.HorizontalResolution, bitBottomScreen.VerticalResolution);
                    using (Graphics gr = Graphics.FromImage(bitBlack))
                    {
                        gr.Clear(Color.Black);
                    }
                    picRslt = (Bitmap)MergeScreenshot(bitBlack, bitBottomScreen);
                }
                else
                {
                    Bitmap bitTopBlack = new Bitmap(400, 240);
                    bitTopBlack.SetResolution(72, 72);
                    using (Graphics gr = Graphics.FromImage(bitTopBlack))
                    {
                        gr.Clear(Color.Black);
                    }
                    Bitmap bitBottomBlack = new Bitmap(320, 240);
                    bitBottomBlack.SetResolution(72, 72);
                    using (Graphics gr = Graphics.FromImage(bitBottomBlack))
                    {
                        gr.Clear(Color.Black);
                    }
                    picRslt = (Bitmap)MergeScreenshot(bitTopBlack, bitBottomBlack);
                }
            }

            //Form tmpFrm = new Form();
            //PictureBox tmpPb = new PictureBox();
            //tmpPb.Image = picRslt;
            //tmpPb.SizeMode = PictureBoxSizeMode.CenterImage;
            //tmpPb.Width = 400;
            //tmpPb.Height = 480;
            //tmpFrm.Controls.Add(tmpPb);
            //tmpFrm.ClientSize = new System.Drawing.Size(400, 480);
            //tmpFrm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //tmpFrm.MaximizeBox = false;
            //tmpFrm.Show();

            SaveFileDialog fSaveDiag = new SaveFileDialog();
            fSaveDiag.FileName = "3DS_ScreenShot.png";
            fSaveDiag.Filter = "Images (*.png, *.bmp, *.jpg)|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (fSaveDiag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string ext = System.IO.Path.GetExtension(fSaveDiag.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    picRslt.Save(fSaveDiag.FileName, format);

                    MessageBox.Show("儲存成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsBtnOpenTop_Click(object sender, EventArgs e)
        {
            LoadTopScreen();
        }

        private void tsBtnOpenBottom_Click(object sender, EventArgs e)
        {
            LoadBottomScreen();
        }

        private void 關閉程式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private Image MergeScreenshot(Image top, Image bot)
        {
            Bitmap imgRslt = new Bitmap(400, 480);
            imgRslt.SetResolution(top.HorizontalResolution, top.VerticalResolution);

            Graphics gr = Graphics.FromImage(imgRslt);

            gr.Clear(Color.Black);
            gr.DrawImageUnscaled(top, 0, 0);
            gr.DrawImageUnscaled(bot, 40, 240);

            gr.Dispose();

            return imgRslt;
        }

        private void LoadTopScreen()
        {
            OpenFileDialog fOpenDiag = new OpenFileDialog();
            fOpenDiag.Filter = "Image File (*.bmp, *.png, *.jpg)|*.bmp;*.png;*.jpg";
            fOpenDiag.FilterIndex = 1;
            fOpenDiag.RestoreDirectory = true;

            Stream tmpStream = null;

            if (fOpenDiag.ShowDialog().Equals(DialogResult.OK))
            {
                try
                {
                    if ((tmpStream = fOpenDiag.OpenFile()) != null)
                    {
                        using (tmpStream)
                        {
                            Bitmap topImage = (Bitmap)Image.FromStream(tmpStream);
                            if (topImage.Width.Equals(400) && topImage.Height.Equals(240))
                                picTopScreen.Image = topImage;
                            else
                                throw new Exception("圖片大小不正確");
                        }

                        string[] tmpFileNameStruct = fOpenDiag.FileName.Split('\\');
                        if (tmpFileNameStruct[tmpFileNameStruct.Length - 1].IndexOf("top_").Equals(0))
                        {
                            tmpFileNameStruct[tmpFileNameStruct.Length - 1] = tmpFileNameStruct[tmpFileNameStruct.Length - 1].Replace("top_", "bot_");
                            string tmpPath = String.Join("\\", tmpFileNameStruct);
                            if (File.Exists(tmpPath))
                            {
                                if (MessageBox.Show("是否載入相對應的下螢幕截圖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                                {
                                    Bitmap botImage = (Bitmap)Image.FromFile(tmpPath);
                                    if (botImage.Width.Equals(320) && botImage.Height.Equals(240))
                                        picBottomScreen.Image = botImage;
                                    else
                                        throw new Exception("圖片大小不正確");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBottomScreen()
        {
            OpenFileDialog fOpenDiag = new OpenFileDialog();
            fOpenDiag.Filter = "Image File (*.bmp, *.png, *.jpg)|*.bmp;*.png;*.jpg";
            fOpenDiag.FilterIndex = 1;
            fOpenDiag.RestoreDirectory = true;

            Stream tmpStream = null;

            if (fOpenDiag.ShowDialog().Equals(DialogResult.OK))
            {
                try
                {
                    if ((tmpStream = fOpenDiag.OpenFile()) != null)
                    {
                        using (tmpStream)
                        {
                            Bitmap topImage = (Bitmap)Image.FromStream(tmpStream);
                            if (topImage.Width.Equals(320) && topImage.Height.Equals(240))
                                picBottomScreen.Image = topImage;
                            else
                                throw new Exception("圖片大小不正確");
                        }
                    }

                    string[] tmpFileNameStruct = fOpenDiag.FileName.Split('\\');
                    if (tmpFileNameStruct[tmpFileNameStruct.Length - 1].IndexOf("bot_").Equals(0))
                    {
                        tmpFileNameStruct[tmpFileNameStruct.Length - 1] = tmpFileNameStruct[tmpFileNameStruct.Length - 1].Replace("bot_", "top_");
                        string tmpPath = String.Join("\\", tmpFileNameStruct);
                        if (File.Exists(tmpPath))
                        {
                            if (MessageBox.Show("是否載入相對應的上螢幕截圖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                            {
                                Bitmap topImage = (Bitmap)Image.FromFile(tmpPath);
                                if (topImage.Width.Equals(400) && topImage.Height.Equals(240))
                                    picTopScreen.Image = topImage;
                                else
                                    throw new Exception("圖片大小不正確");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExitApplication()
        {
            Close();
        }
    }
}
