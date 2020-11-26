using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class BotonesNumerados: UserControl
    {
        private int num;
        private int tam;

        public BotonesNumerados() : this(9, 135)
        {
            InitializeComponent();
        }

        public BotonesNumerados(int numero, int tamaño)
        {
            num = numero;
            tam = tamaño;
            int posX = 0;
            int posY = 0;
            Button nuevo;
            for(int i = 0; i < num; i++)
            {
                nuevo = new System.Windows.Forms.Button();
                nuevo.Name = "button" + (i + 1);
                nuevo.Size = new System.Drawing.Size((int)Math.Ceiling(tam / Math.Ceiling(Math.Sqrt(num))), (int)Math.Ceiling(tam / Math.Ceiling(Math.Sqrt(num))));
                nuevo.TabIndex = i;
                nuevo.Text = (i + 1).ToString();
                nuevo.UseVisualStyleBackColor = true;
                if(i > 1)
                {
                    if(i % Math.Sqrt(num) == 0)
                    {
                        posX = 0;
                        posY += (int)Math.Ceiling(tam / Math.Ceiling(Math.Sqrt(num)));
                    }
                }
                nuevo.Location = new System.Drawing.Point(posX, posY);
                posX += (int)Math.Ceiling(tam / Math.Ceiling(Math.Sqrt(num)));
                Controls.Add(nuevo);
                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            }
            InitializeComponent();
        }
    }
}
