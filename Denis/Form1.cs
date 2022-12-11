using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Timer = System.Windows.Forms.Timer;

namespace Denis
{
    public partial class Form1 : Form
    {
        List<int> continue_to_live = new List<int>() { };
        List<int> be_born = new List<int>() { };
        public Form1()
        {
            this.Text = "оп-оп живём живём";         
            InitializeComponent();
            MySettinngs();
            CreateMap();
            NewMap();    
            Info.Enabled = false;
        }
        Graphics g;
        private const int MapSize = 1500;
         int Cellize = 1;
        private const int originalCellize = 1;
        private int fieldsz = MapSize * originalCellize;
        private int zoom = 1;
        int k_move = 4;
        bool timer=false;
        Timer mytimer;

        


        int[,] map = new int[MapSize, MapSize];
        int[,] live_map = new int[MapSize, MapSize];
        int[,] next_map = new int[MapSize, MapSize];

        private void CreateMap()
        {
            for (int i = 0; i < 9; i++)
            {
                HowMuchToBeBorn.Items.Add(i);
                HowMuchToContinueLive.Items.Add(i);
            }
            
            mytimer = new Timer();
            mytimer.Interval = 40;
            mytimer.Tick += new EventHandler(NextPhase);
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    map[i, j] = 0;
                    live_map[i, j] = 0;
                }
            }
            Bitmap bmp = new Bitmap(fieldsz, fieldsz);
            field.Image = bmp;
            
            g = Graphics.FromImage(field.Image);
        }

        public int NumberOfNeighbors(int x, int y)
        {
            int number = 0;
            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                    if ((i != x || j != y) && map[(i + MapSize) % MapSize, (j + MapSize) % MapSize] == 1)
                        number++;
            return number;
        }
        void DieOrBorn()
        {
            for (int i = 0; i < MapSize; i++)
                for (int j = 0; j < MapSize; j++)
                {
                    if (be_born.Contains(NumberOfNeighbors(i, j)) && map[i, j] == 0)   // оживает
                    {
                        next_map[i, j] = 1;
                        live_map[i, j] += 1;
                    }
                    if (continue_to_live.Contains(NumberOfNeighbors(i, j)) && map[i, j] == 1) // продолжает жить
                    {
                        next_map[i, j] = 1;
                        live_map[i, j] += 1;
                    }
                    if (!continue_to_live.Contains(NumberOfNeighbors(i, j)) && map[i, j] == 1) // умирает
                    {
                        next_map[i, j] = 0;
                        live_map[i, j] = 0;
                    }
                }
            for (int i = 0; i < MapSize; i++)
                for (int j = 0; j < MapSize; j++)
                {
                    map[i, j] = next_map[i, j];
                    next_map[i, j] = 0;
                }
        }
        private void Generate(object sender, EventArgs e)
        {
            Generatefield();
            NewMap();
        }
        private void Generatefield()
        {
            Random rnd = new Random();
            for (int i = 0; i < MapSize; i++)
                for (int j = 0; j < MapSize; j++)
                {
                    map[i, j] = rnd.Next(0, 2);
                    live_map[i, j] = map[i, j] ==0 ? 0: live_map[i, j]+1;
                    next_map[i, j] = 0;
                }
        }

        private void NextPhase(object sender, EventArgs e)
        {
            DieOrBorn();
            NewMap();
        }

        public void NewMap()
        {
            Random r = new Random();
            g.Clear(Color.White);
            for (int y = 0; y < MapSize; y++)
            {
                for (int x = 0; x < MapSize; x++)
                {
                    if (map[y, x] == 1)
                    {
                        //SolidBrush brush = new SolidBrush(Color.FromArgb(r.Next(56, 255), r.Next(78, 255), r.Next(45, 233)));
                        g.FillRectangle(Brushes.Black, y * Cellize, x * Cellize, Cellize, Cellize);
                        
                    }
                }
            }
            field.Refresh();
        }


        private void field_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / Cellize;
            int y = e.Y / Cellize;
            if (x < 0 || y<0 || x >= MapSize || y>= MapSize) 
                return;
            if (e.Button != MouseButtons.Left)
                return;
            map[x, y] = 1 - map[x ,y];
            live_map[x, y] = map[x, y] == 1 ? 1 : 0 ;
            NewMap();
        }


        private void PlusZoom_Click(object sender, EventArgs e)
        {
            if (zoom < 5)
            {
                zoom = zoom + 1;
                field.Width = fieldsz * zoom;
                field.Height = fieldsz * zoom;
                Cellize = originalCellize * zoom;
                LabelZoom.Text = $"{zoom}";
                field.Image = new Bitmap(field.Width, field.Height);
                g = Graphics.FromImage(field.Image);
                NewMap();
            }
        }

        private void MinusZoom_Click(object sender, EventArgs e)
        {
            if (zoom > 1)
            {
                zoom = zoom - 1;
                field.Width = fieldsz * zoom;
                field.Height =  fieldsz * zoom;
                Cellize = originalCellize * zoom;
                LabelZoom.Text = $"{zoom}";
                field.Image = new Bitmap(field.Width, field.Height);
                g = Graphics.FromImage(field.Image);
                NewMap();
            }
        }
        private void NullZoom()
        {
            while (zoom > 1)
            {
                zoom = zoom - 1;
                field.Width = fieldsz * zoom;
                field.Height = fieldsz * zoom;
                Cellize = originalCellize * zoom;
                LabelZoom.Text = $"{zoom}";
                field.Image = new Bitmap(field.Width, field.Height);
                g = Graphics.FromImage(field.Image);
                NewMap();
            }
        }

        private void TimerState_Click(object sender, EventArgs e)
        {
            timer = !timer;
            TimerState.Text = timer ? "Timer stop!" : "Timer start!";
            if (timer)
            {
                mytimer.Start();
            }
            else
            {
                mytimer.Stop();
            }    
        }

        private void KthNext_Click(object sender, EventArgs e)
        {
            if (KSteps.Value > 0)
            {
                k_move = (int)KSteps.Value;
                for (int i = 0; i < k_move; i++)
                {
                    DieOrBorn();
                    NewMap();
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        private void field_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / Cellize;
            int y = e.Y / Cellize;
            if (x < 0 || y < 0 || x >= MapSize || y >= MapSize)
                return;
            Info.Text = $"Клетка {x} : {y} живёт {live_map[x,y]} ходов";
        }

        private void TextSave_Click(object sender, EventArgs e)
        {
            NullZoom();
            SaveText(sender, e);
        }

        private void SaveText(object sender, EventArgs e)
        {
            NullZoom();
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filePath = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    filePath = saveFileDialog1.FileName;
                    myStream.Close();
                }
            }
            if (filePath == String.Empty)
                return;
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    ans.Append(map[i, j]);
                }
                ans.Append('\n');
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(ans);
            }
        }

        private void SavePicture_Click(object sender, EventArgs e)
        {
            NullZoom();
            SavePic(sender,  e);
        }
        private void SavePic(object sender, EventArgs e)
        {
            NullZoom();
            if (field.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";

                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        field.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TextOpen_Click(object sender, EventArgs e)
        {
            NullZoom();
            OpenText(sender, e);
        }
        private void OpenText(object sender, EventArgs e)
        {
            NullZoom();
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath == String.Empty)
                return;
            for (int i = 0; i < MapSize; i++)
                for (int j = 0; j < MapSize; j++)
                {
                    map[i, j] = 0;
                }

                    using (StreamReader streamreader = new StreamReader(filePath))
            {
                int i = 0;
                while (streamreader.Peek() >= 0)
                {
                    string s = streamreader.ReadLine();
                    if (s.Length > 0)
                    {
                        for (int j = 0; j < MapSize; j++)
                        {
                            if (j<s.Length)
                                map[i, j] = Int32.Parse(s[j] + " ");
                            else
                                map[i, j] = 0;
                        }
                    }
                    i++;
                }
            }
            NewMap();
        }
        private void OpenPicture_Click(object sender, EventArgs e)
        {
            NullZoom();
            OpenPic( sender,  e);
        }
        private void OpenPic(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath == String.Empty)
                return;
            Bitmap bitmap = new Bitmap(filePath);

            for (int i = 0; i < MapSize; i++)
                for (int j = 0; j < MapSize; j++)
                {
                    map[i, j] = 0;
                    if (i * Cellize + Cellize / 2 < bitmap.Width  && j * Cellize + Cellize / 2 < bitmap.Height )
                    {
                        Color colour = bitmap.GetPixel(i * Cellize + Cellize / 2, j * Cellize + Cellize / 2);

                        if (colour.Name == "ff000000")
                            map[i, j] = 1;
                    }
                }

            NewMap();
        }

        private void NewRulesToLive(object sender, EventArgs e)
        {
            continue_to_live.Clear();
            string to_live_str = "";
            foreach (var item in HowMuchToContinueLive.SelectedItems)
            {
                int q = Convert.ToInt32(item);
                continue_to_live.Add(q);
                to_live_str += "" + q;
            }
            Properties.Settings.Default.live_settings = to_live_str;
            Properties.Settings.Default.Save();
        }

        private void NewRulesToBeBorn(object sender, EventArgs e)
        {
            be_born.Clear();
            string be_born_str = "";
            foreach (var item in HowMuchToBeBorn.SelectedItems)
            {
                int q = Convert.ToInt32(item);
                be_born.Add(q);
                be_born_str += "" + q;
            }
            
            Properties.Settings.Default.tolive_settings = be_born_str;
            Properties.Settings.Default.Save();
        }
        public void MySettinngs()
        {
            string s1 = Properties.Settings.Default.live_settings;
            string s2 = Properties.Settings.Default.tolive_settings;
            for (int i = 0; i < s1.Length; i++)
            {
                HowMuchToContinueLive.SelectedItems.Add(s1[i] - 48);
                continue_to_live.Add(Convert.ToInt32(s1[i])-48);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                HowMuchToBeBorn.SelectedItems.Add(s2[i]-48);
                be_born.Add(Convert.ToInt32(s2[i]) - 48);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            NullZoom();
            DialogResult result = MessageBox.Show("Сохранить изменения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult result1 = MessageBox.Show("Вы хотите сохранить картинку", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    SavePic(sender, e);
                }
                else
                {
                    SaveText(sender, e);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Загрузить поле?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult result1 = MessageBox.Show("Вы хотите загрузить картинку", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    OpenPic(sender, e);
                }
                else
                {
                    OpenText(sender, e);
                }
            }

        }
    }
}