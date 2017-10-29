using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace fracts
{
	public partial class Form1 : Form
	{
		Bitmap bmp;
        Pen pen = new Pen(new SolidBrush(Color.Black), 1);

        public Form1()
		{
			InitializeComponent();
			bmp = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
			pictureBox.Image = bmp;
			//pen.EndCap = LineCap.ArrowAnchor; //направление векторов
		}

		Graphics g;
		List<My_point> points = new List<My_point>(); // список точек
		List<edge> edges = new List<edge>(); // список рёбер
		My_point center_point = null; // центральная точка фигуры
		SolidBrush brush = new SolidBrush(Color.LightGreen);

		/// <summary>
		/// Перемещение фигуры на заданные сдвиги по Х и У
		/// </summary>
		private void butt_dis_Click(object sender, EventArgs e)
		{
			int kx = (int)set_dis_x.Value, ky = (int)set_dis_y.Value;
			foreach (My_point p in points)
			{
				p.X += kx;
				p.Y += ky;
			}
			redrawImage();
		}


		/// <summary>
		/// Изменение масштаба заданной фигуры
		/// </summary>
		private void butt_sc_Click(object sender, EventArgs e)
		{
			My_point center = centerPoint();
			double kx = (double)set_sc_x.Value;
			double ky = (double)set_sc_y.Value;
            center_point = centerPoint();
            foreach (My_point p in points)
			{
				p.X -= center_point.X;
				p.Y -= center_point.Y;
				p.X = (int)(p.X * kx);
				p.Y = (int)(p.Y * ky);
				p.X += center_point.X;
				p.Y += center_point.Y;
			}
			redrawImage();
		}

		/// <summary>
		/// Очищаем рисунок
		/// </summary>
		private void butt_clear_Click(object sender, EventArgs e)
		{
			g.Clear(Color.White);
			points.Clear();
			edges.Clear();
			pictureBox.Image = bmp;

			set_sc_x.Value = set_sc_y.Value = 1M;
		}

		/// <summary>
		/// Вычисляем координаты центра фигуры
		/// </summary>
		private My_point centerPoint()
		{
			if (points.Count == 0)
				return null;
			int sumX = 0, sumY = 0;
			foreach (My_point p in points)
			{
				sumX += (int)p.X;
				sumY += (int)p.Y;
			}
			sumX /= points.Count;
			sumY /= points.Count;
			return new My_point(sumX, sumY);
		}

		/// <summary>
		/// Перерисовываем pictureBox
		/// </summary>
		private void redrawImage()
		{
			g.Clear(Color.White);
			foreach (edge e in edges)
				draw_edge(pen, e);
			pictureBox.Image = bmp;
			center_point = centerPoint();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			g = Graphics.FromImage(bmp);
		}

		// _______ ФРАКТАЛЫ________

		string file_name;
		private void butt_open_fract_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				file_name = openFileDialog1.FileName;
			}
		}

		private void butt_draw_fract_Click(object sender, EventArgs e)
		{
            butt_clear_Click(sender,e);

            if (file_name == "")
			{
				MessageBox.Show("Выберите файл!", "Ошибка", MessageBoxButtons.OK);
				return;
			}
			int level = (int)num_iter_fract.Value;
			make_fract(file_name, level);
			draw_fract();
		}

		// построение фрактала
		private void make_fract(string fileName, int level)
		{
			LSystem lsys = new LSystem(fileName);
			string actions = lsys.getResult(level);
			double angle = lsys.rotateAngle;
			Stack<State> stack = new Stack<State>();
			State currentState = new State(0, new My_point(0, 0), new My_point(40, 0));
			for (int i = 0; i < actions.Length; i++)
			{
				if (actions[i] == 'F')
				{
					My_point p1 = new My_point(currentState.prevPoint.X, currentState.prevPoint.Y);
					My_point p2 = new My_point(currentState.nextPoint.X, currentState.nextPoint.Y);
					edges.Add(new edge(p1, p2));
					currentState.prevPoint.X = currentState.nextPoint.X;
					currentState.prevPoint.Y = currentState.nextPoint.Y;
					displacement(currentState.nextPoint, 40, 0);
					rotate(currentState.nextPoint, currentState.prevPoint, currentState.angle);
				}
				else if (actions[i] == '-')
				{
					rotate(currentState.nextPoint, currentState.prevPoint, angle);
					currentState.angle += angle;
				}
				else if (actions[i] == '+')
				{
					rotate(currentState.nextPoint, currentState.prevPoint, -angle);
					currentState.angle -= angle;
				}
				else if (actions[i] == '[')
				{
					stack.Push(new State(currentState.angle, new My_point(currentState.prevPoint.X, currentState.prevPoint.Y), new My_point(currentState.nextPoint.X, currentState.nextPoint.Y)));
				}
				else if (actions[i] == ']')
				{
					State prevState = stack.Pop();
					currentState.angle = prevState.angle;
					currentState.prevPoint = prevState.prevPoint;
					currentState.nextPoint = prevState.nextPoint;
				}
			}
		}

		// находим самую левую и верхнюю точки
		private void find_left_up(ref double left, ref double up) 
		{
			left = points[0].X;
			up = points[0].Y;
			for (int i = 1; i < points.Count; i++)
			{
				if (points[i].Y < up)
					up = points[i].Y;
				if (points[i].X < left)
					left = points[i].X;
			}
		}

		// находим самую правую и нижнюю точки
		private void find_right_down(ref double right, ref double down) 
		{
			right = points[0].X;
			down = points[0].Y;
			for (int i = 1; i < points.Count; i++)
			{
				if (points[i].Y > down)
					down = points[i].Y;
				if (points[i].X > right)
					right = points[i].X;
			}
		}

		// масштабируем, чтоб все помещалось
		private void rescale() 
		{
			double left = 0, right = 0, up = 0, down = 0;
			find_left_up(ref left, ref up);
			foreach (My_point p in points)
			{
				p.X -= left;
				p.Y -= up;
			}
			find_right_down(ref right, ref down);
			double kx = (double)pictureBox.Width / (right + 1);
			double ky = (double)pictureBox.Height / (down + 1);
			double k = Math.Min(kx, ky);
			foreach (My_point p in points)
			{
				p.X *= k;
				p.Y *= k;
			}
		}

		// смещение
		private void displacement(My_point p, int kx, int ky) 
		{
			p.X += kx;
			p.Y += ky;
		}

		// поворот
		private void rotate(My_point p, My_point rotatePoint, double a) 
		{
			double angle = (a * Math.PI) / 180;
			p.X -= rotatePoint.X;
			p.Y -= rotatePoint.Y;
			double xa = p.X * Math.Cos(angle) + p.Y * Math.Sin(angle);
			double ya = p.Y * Math.Cos(angle) - p.X * Math.Sin(angle);
			p.X = xa + rotatePoint.X;
			p.Y = ya + rotatePoint.Y;
		}

		// рисуем фрактал
		private void draw_fract() 
		{
			build_points();
			rescale();
			foreach (edge e in edges)
				draw_edge(pen, e);
			pictureBox.Image = bmp;
		}

		// рисуем ребро
		private void draw_edge(Pen pen, edge e) 
		{
			g.DrawLine(pen, (int)Math.Round(e.P1.X), (int)Math.Round(e.P1.Y), (int)Math.Round(e.P2.X), (int)Math.Round(e.P2.Y));
		}

		private void build_points()
		{
			for (int i = 0; i < edges.Count; i++)
			{
				points.Add(edges[i].P1);
				points.Add(edges[i].P2);
			}
		}

        class DiamondSquare
        {
            LinkedList<PointF> list = new LinkedList<PointF>();
            float startX, startY;
            //Кол-во итераций
            int gens;
            //Коэффициент шероховатости
            float R;

            public DiamondSquare(int _gens, float x, float y, float r)
            {
                gens = _gens;
                startX = x;
                startY = y;
                R = r;
                list.AddFirst(new PointF(0, startY));
                list.AddLast(new PointF(1023, startY));
            }

            public void Iterate()
            {
                Random r = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < gens; ++i)
                {
                    LinkedListNode<PointF> cur = list.First;
                    while (cur.Next != null)
                    {
                        float _length = (float)Math.Sqrt(Math.Pow((double)cur.Value.Y - (double)cur.Next.Value.Y, 2)
                            + Math.Pow((double)cur.Value.X - (double)cur.Next.Value.X, 2));
                        float h = Math.Abs(cur.Value.Y - cur.Next.Value.Y) / 2 + cur.Value.Y;
                        h += (float)r.Next((int)(-_length * R/100), (int)(_length * R/100));
                        list.AddAfter(cur, new PointF((cur.Next.Value.X - cur.Value.X) / 2 + cur.Value.X, h));
                        cur = cur.Next.Next;
                    }
                }
            }

            public void Draw(Graphics graphics)
            {
                LinkedListNode<PointF> cur = list.First;
                while (cur.Next != null)
                {
                    graphics.DrawLine(new Pen(new SolidBrush(Color.Black), 4f), cur.Value, cur.Next.Value);
                    cur = cur.Next;
                }

                LinkedList<PointF> _list = new LinkedList<PointF>(list);
                _list.AddFirst(new PointF(0, 1024));
                _list.AddLast(new PointF(1024, 1024));
                PointF[] points = _list.ToArray<PointF>();
                graphics.FillPolygon(new SolidBrush(Color.Black), points);
            }
        }

        private void diamond_Click(object sender, EventArgs e)
        {
            DiamondSquare ds = new DiamondSquare(
                (int)num_iter_fract.Value,
                0,
                512f,
                (float)shoroh.Value
                );

            ds.Iterate();
            Graphics graphics;

            graphics = Graphics.FromImage(pictureBox.Image);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.Clear(pictureBox.BackColor);

            ds.Draw(graphics);
            pictureBox.Refresh();
        }
    }

    public class My_point : IComparable<My_point>
	{
		public double X, Y;
		public My_point(double x, double y) { X = x; Y = y; }
		public static bool operator ==(My_point p1, My_point p2)
		{
			if (System.Object.ReferenceEquals(p1, p2))
				return true;
			if (((object)p1 == null) || ((object)p2 == null))
				return false;
			return p1.X == p2.X && p1.Y == p2.Y;
		}
		public static bool operator !=(My_point p1, My_point p2)
		{
			return !(p1 == p2);
		}

		public static bool operator <(My_point p1, My_point p2)
		{
			return p1.X < p2.X;
		}

		public static bool operator >(My_point p1, My_point p2)
		{
			return p1.X > p2.X;
		}

		public int CompareTo(My_point obj)
		{
			if (this.X > obj.X)
				return 1;
			else if (this.X < obj.X)
				return -1;
			else 
				return 0;
		}
	}

	public class edge
	{
		public My_point P1, P2;
		public edge(My_point p1, My_point p2) { P1 = p1; P2 = p2; }
		public bool contains(My_point p) { return p == P1 || p == P2; }
		public My_point start() { return P1; }
		public My_point end() { return P2; }
	}

	public class LSystem
	{
		string axiom = ""; // аксиома
		Dictionary<char, string> rules = new Dictionary<char, string>(); // список правил
		public double rotateAngle = 0; // угол поворта

		private void addRule(string s) // добавляем новое правило
		{
			rules.Add(s[0], s.Substring(3));
		}

		public LSystem(string fileName)
		{
			string[] lines = System.IO.File.ReadAllLines(fileName);
			string[] firstLine = lines[0].Split(' ');
			axiom = firstLine[0];
			rotateAngle = Convert.ToDouble(firstLine[1]);
			for (int i = 1; i < lines.Count(); i++)
				addRule(lines[i]);
		}

		// выводим последовательность действий для заданого числа итераций
		public string getResult(int level) 
		{
			string res = axiom; // стартовый символ
			while (level > 0) // выполняем итерации
			{
				for (int i = 0; i < res.Length; i++)
					if (char.IsLetter(res[i]))
					{
						string rule = "";
						bool flag = rules.TryGetValue(res[i], out rule);
						if (flag)
						{
							res = (res.Remove(i, 1)).Insert(i, rule);
							i += rule.Length - 1;
						}
					}
				--level;
			}
			return res;
		}
	}

	public class State
	{
		public double angle;
		public My_point prevPoint, nextPoint;

		public State(double a, My_point pp, My_point np)
		{
			angle = a;
			prevPoint = pp;
			nextPoint = np;
		}
	}
}