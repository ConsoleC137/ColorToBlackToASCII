using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            OpenFileDialog = new OpenFileDialog()
            {
                Filter = "Image | *.bmp; *.png; *.jpg; *.jpeg",
                Title = "Какое изображение преобразовать?"
            };
        }

        private void Initze()
        {
            SaveFileDialogBlack = new SaveFileDialog()
            {
                Filter = "Image | *.bmp; *.png; *.jpg; *.jpeg",
                Title = "Куда сохранить чёрно-белое изображение?",
                DefaultExt = Ext,
                FileName = NameF + "_Black" + Ext
            };

            SaveFileDialogNegative = new SaveFileDialog()
            {
                Filter = "Image | *.bmp; *.png; *.jpg; *.jpeg",
                Title = "Куда сохранить негативное изображение?",
                DefaultExt = Ext,
                FileName = NameF + "_Negative" + Ext
            };

            SaveFileDialogASCII = new SaveFileDialog()
            {
                Filter = "Text | *.txt;",
                Title = "Куда сохранить ASCII изображение?",
                DefaultExt = ".txt",
                FileName = NameF + "_ASCII" + ".txt"
            };
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            labelB.Text = "0%";
            labelN.Text = "0%";
            labelA.Text = "0%";
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;

            MAX_WIDTH = Convert.ToInt32(textBoxWidth.Text);

            if (textBoxHeight.Text.Contains("."))
                textBoxHeight.Text = textBoxHeight.Text.Replace('.', ',');

            K_HEIGHT = Convert.ToDouble(textBoxHeight.Text);

            IsRunning = false;
            while (!IsRunning)
            {
                if (BlackCheckBox.Checked || NegativeCheckBox.Checked || ASCIICheckBox.Checked)
                {
                    if (OpenFileDialog.ShowDialog()==DialogResult.OK)
                    {
                        if (OpenFileDialog.FileName != "")
                        {
                            NameExt(OpenFileDialog.FileName);
                            Initze();
                        }
                        else
                            break;

                        Bitmap bitmap = new Bitmap(Image.FromFile(OpenFileDialog.FileName));
                        Bitmap bitmapClone = (Bitmap)bitmap.Clone();
                        Bitmap bitmapClone1 = (Bitmap)bitmap.Clone();

                        if (BlackCheckBox.Checked && SaveFileDialogBlack.ShowDialog() == DialogResult.OK)
                        {
                            BlackFunc(bitmap, SaveFileDialogBlack.FileName);
                        }
                        if (NegativeCheckBox.Checked && SaveFileDialogNegative.ShowDialog() == DialogResult.OK)
                        {
                            NegativeFunc(bitmapClone, SaveFileDialogNegative.FileName);
                        }
                        if (ASCIICheckBox.Checked && SaveFileDialogASCII.ShowDialog() == DialogResult.OK)
                        {
                            ASCIIFunc(bitmapClone1, SaveFileDialogASCII.FileName);
                        }
                    }
                }
                else
                    MessageBox.Show("Выбирете режим!", "Ошибка");

                IsRunning = true;
                GC.Collect();
            }
        }
        private int MAX_WIDTH { get; set; }
        private double K_HEIGHT { get; set; }
        private const double K = 174.496644295302;
        private static char[] Symbols = { '@', '#', '&', '$', '%', '?', '/', ':', ',', '.' };
        private static string Ext { get; set; }
        private static string NameF { get; set; }
        private static OpenFileDialog OpenFileDialog { get; set; }
        private static SaveFileDialog SaveFileDialogBlack { get; set; }
        private SaveFileDialog SaveFileDialogNegative { get; set; }
        private bool IsRunning { get; set; }
        public SaveFileDialog SaveFileDialogASCII { get; private set; }

        private delegate void Prog(int x);
        private delegate void Prog1();

        private void NegativeFunc(Bitmap invImage, string path)
        {
            new Thread(() =>
            {
                Prog prog1 = (x) =>
                {
                    labelN.Text = $"{x}%";
                };

                Prog1 prog1End = () =>
                {
                    labelN.Text = "100%";
                };

                Prog1 bar1 = () =>
                { progressBar2.PerformStep(); progressBar2.Value--; progressBar2.PerformStep(); };

                Prog1 bar1end = () =>
                { progressBar2.Value = progressBar2.Maximum; };
                int x = 0;
                int counter = 0;
                int hundred = invImage.Height / 100;
                int counterbar = 0;
                int ten = invImage.Height / 10;
                Color inv;
                for (int i = 0; i < invImage.Height; i++)
                {
                    counter++;
                    counterbar++;
                    for (int j = 0; j < invImage.Width; j++)
                    {
                        inv = invImage.GetPixel(j, i);

                        invImage.SetPixel(j, i, Color.FromArgb(255 - inv.R, 255 - inv.G, 255 - inv.B));
                    }
                    if (counterbar == ten)
                    {
                        progressBar2.Invoke(bar1);
                        counterbar = 0;
                    }
                    if (counter == hundred)
                    {
                        x++;
                        labelN.Invoke(prog1, x);
                        counter = 0;
                    }
                }
                progressBar2.Invoke(bar1end);
                labelN.Invoke(prog1End);
                invImage.Save(path);
            }).Start();
            GC.Collect();

        }
        private void BlackFunc(Bitmap imageBlack, string path)
        {
            new Thread(() =>
            {
                Prog prog1 = (x) =>
                { labelB.Text = $"{x}%"; };

                Prog1 prog1End = () =>
                { labelB.Text = "100%"; };

                Prog1 bar1 = () =>
                { progressBar1.PerformStep(); progressBar1.Value--; progressBar1.PerformStep(); };

                Prog1 bar1end = () =>
                { progressBar1.Value = progressBar1.Maximum; };
                int x = 0;
                int counter = 0;
                int hundred = imageBlack.Height / 100;
                int counterbar = 0;
                int ten = imageBlack.Height / 10;
                Color avgC;
                int avg;
                for (int i = 0; i < imageBlack.Height; i++)
                {
                    counter++;
                    counterbar++;
                    for (int j = 0; j < imageBlack.Width; j++)
                    {
                        avgC = imageBlack.GetPixel(j, i);
                        avg = (avgC.R + avgC.G + avgC.B) / 3;
                        imageBlack.SetPixel(j, i, Color.FromArgb(avg, avg, avg));
                    }
                    if (counterbar == ten)
                    {
                        progressBar1.Invoke(bar1);
                        counterbar = 0;
                    }
                    if (counter == hundred)
                    {
                        x++;
                        labelB.Invoke(prog1, x);
                        counter = 0;
                    }
                }
                progressBar1.Invoke(bar1end);
                labelB.Invoke(prog1End);
                imageBlack.Save(path);


            }).Start();
            GC.Collect();
        }
        private void ASCIIFunc(Bitmap ResizeImage7, string path)
        {
            new Thread(() =>
            {
                Bitmap ResizeImage = ResizeBitmap(ResizeImage7);
                Prog prog1 = (x) =>
                {
                    labelA.Text = $"{x}%";
                };

                Prog1 prog1End = () =>
                {
                    labelA.Text = "100%";
                };

                Prog1 bar1 = () =>
                { progressBar3.PerformStep(); progressBar3.Value--; progressBar3.PerformStep(); };

                Prog1 bar1end = () =>
                { progressBar3.Value = progressBar3.Maximum; };
                int index;
                int avg1;
                int x = 0;
                int counter = 0;
                int hundred = ResizeImage.Height / 100;
                int counterbar = 0;
                int ten = ResizeImage.Height / 10;
                using FileStream file = new FileStream(path, FileMode.Create);
                using StreamWriter streamWriter = new StreamWriter(file);
                for (int i = 0; i < ResizeImage.Height; i++)
                {
                    for (int j = 0; j < ResizeImage.Width; j++)
                    {
                        avg1 = (ResizeImage.GetPixel(j, i).R
                                     + ResizeImage.GetPixel(j, i).G
                                     + ResizeImage.GetPixel(j, i).B) / 3;
                        ResizeImage.SetPixel(j, i, Color.FromArgb(avg1, avg1, avg1));

                        index = (int)Map(avg1, 0, 255, 0, Symbols.Length - 1);

                        streamWriter.Write(Symbols[index]);
                    }
                    streamWriter.Write("\n");
                    if (counterbar == ten)
                    {
                        progressBar3.Invoke(bar1);
                        counterbar = 0;
                    }
                    if (counter == hundred)
                    {
                        x++;
                        labelA.Invoke(prog1, x);
                        counter = 0;
                    }
                }
                progressBar3.Invoke(bar1end);
                labelA.Invoke(prog1End);
            }).Start();
            GC.Collect();

        }
        public static void NameExt(string path)
        {
            string[] exPath = path.Split('\\');
            string[] fileName = exPath[exPath.Length - 1].Split('.');
            Ext = "." + fileName[1];
            NameF = fileName[0];
        }
        private static float Map(float valueToMap,
            float start1,
            float stop1,
            float start2,
            float stop2)
        {
            return ((valueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
        private Bitmap ResizeBitmap(Bitmap bitmap)
        {
            var maxWidth = MAX_WIDTH;
            var newHeight = bitmap.Height / K_HEIGHT * maxWidth / bitmap.Width;
            if (bitmap.Width > maxWidth || bitmap.Height > newHeight)
            {
                bitmap = new Bitmap(bitmap, new Size(maxWidth, (int)newHeight));
            }
            return bitmap;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
