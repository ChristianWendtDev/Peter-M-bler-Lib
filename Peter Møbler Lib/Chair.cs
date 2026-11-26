using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Peter_Møbler_Lib
{
	public class Chair : Product
	{
		private List<string> _materials;
		private int _heigth;
		private int _width;
		private int _depth;

		public Chair() : base()
		{
			Materials = new List<string>() { "dummy" };
			Heigth = 50;
			Width = 30;
			Depth = 50;
		}
		public Chair(int heigth, int width, int depth, List<string> materials, int productNo, int price, string name) : base(productNo, price, name)
		{
			Heigth = heigth;
			Width = width;
			Depth = depth;
			Materials = materials;
		}

		public List<string> Materials
		{
			get { return _materials; }
			set
			{
				if (value.Count < 1)
					throw new ArgumentException("there must be atleast 1 material");

				_materials = value;
			}
		}
		public int Heigth
		{
			get { return _heigth; }
			set
			{
				if (value < 50 || value > 200)

					throw new ArgumentException("heigth must be between 50 and 200 cm");

				_heigth = value;
			}
		}
		public int Width
		{
			get { return _width; }
			set
			{
				if (value < 30 || value > 130)
					throw new ArgumentException("width must be between 30 and 130 cm");
				_width = value;
			}
		}

		public int Depth
		{
			get { return _depth; }
			set
			{
				if (value < 50 || value > 140)
					throw new ArgumentException("depth must be between 50 and 140 cm");

				_depth = value;
			}
		}
		public override string ToString()
		{

			return base.ToString() + $" materials:  {string.Join(", ", Materials)}  Heigth:   {Heigth}   Width:  {Width}   Depth: {Depth}";
		}
	}
}
