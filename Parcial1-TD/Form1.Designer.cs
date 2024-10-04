namespace Parcial1_TD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelsensor1 = new System.Windows.Forms.Panel();
            this.panelsensor2 = new System.Windows.Forms.Panel();
            this.txtsensor1estado = new System.Windows.Forms.Label();
            this.txtsensor2estado = new System.Windows.Forms.Label();
            this.txtPorcentajeIzq = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorcentajeDer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmotorizq = new System.Windows.Forms.Label();
            this.lblmotorder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(237, 52);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(101, 39);
            this.btnAdelante.TabIndex = 0;
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(237, 128);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(101, 39);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(130, 88);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(101, 39);
            this.btnIzquierda.TabIndex = 2;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(344, 88);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(101, 39);
            this.btnDerecha.TabIndex = 3;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sensor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sensor 2";
            // 
            // panelsensor1
            // 
            this.panelsensor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelsensor1.Location = new System.Drawing.Point(370, 241);
            this.panelsensor1.Name = "panelsensor1";
            this.panelsensor1.Size = new System.Drawing.Size(46, 39);
            this.panelsensor1.TabIndex = 6;
            // 
            // panelsensor2
            // 
            this.panelsensor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelsensor2.Location = new System.Drawing.Point(499, 240);
            this.panelsensor2.Name = "panelsensor2";
            this.panelsensor2.Size = new System.Drawing.Size(46, 39);
            this.panelsensor2.TabIndex = 7;
            // 
            // txtsensor1estado
            // 
            this.txtsensor1estado.AutoSize = true;
            this.txtsensor1estado.Location = new System.Drawing.Point(367, 289);
            this.txtsensor1estado.Name = "txtsensor1estado";
            this.txtsensor1estado.Size = new System.Drawing.Size(74, 13);
            this.txtsensor1estado.TabIndex = 0;
            this.txtsensor1estado.Text = "Fuera de linea";
            // 
            // txtsensor2estado
            // 
            this.txtsensor2estado.AutoSize = true;
            this.txtsensor2estado.Location = new System.Drawing.Point(496, 289);
            this.txtsensor2estado.Name = "txtsensor2estado";
            this.txtsensor2estado.Size = new System.Drawing.Size(74, 13);
            this.txtsensor2estado.TabIndex = 8;
            this.txtsensor2estado.Text = "Fuera de linea";
            // 
            // txtPorcentajeIzq
            // 
            this.txtPorcentajeIzq.AutoSize = true;
            this.txtPorcentajeIzq.Location = new System.Drawing.Point(22, 289);
            this.txtPorcentajeIzq.Name = "txtPorcentajeIzq";
            this.txtPorcentajeIzq.Size = new System.Drawing.Size(13, 13);
            this.txtPorcentajeIzq.TabIndex = 9;
            this.txtPorcentajeIzq.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblmotorizq);
            this.panel1.Location = new System.Drawing.Point(25, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 39);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Motor Izquierdo";
            // 
            // txtPorcentajeDer
            // 
            this.txtPorcentajeDer.AutoSize = true;
            this.txtPorcentajeDer.Location = new System.Drawing.Point(136, 289);
            this.txtPorcentajeDer.Name = "txtPorcentajeDer";
            this.txtPorcentajeDer.Size = new System.Drawing.Size(13, 13);
            this.txtPorcentajeDer.TabIndex = 12;
            this.txtPorcentajeDer.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblmotorder);
            this.panel2.Location = new System.Drawing.Point(139, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 39);
            this.panel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Motor Derecho";
            // 
            // lblmotorizq
            // 
            this.lblmotorizq.AutoSize = true;
            this.lblmotorizq.Location = new System.Drawing.Point(12, 12);
            this.lblmotorizq.Name = "lblmotorizq";
            this.lblmotorizq.Size = new System.Drawing.Size(18, 13);
            this.lblmotorizq.TabIndex = 0;
            this.lblmotorizq.Text = "🡩";
            // 
            // lblmotorder
            // 
            this.lblmotorder.AutoSize = true;
            this.lblmotorder.Location = new System.Drawing.Point(13, 12);
            this.lblmotorder.Name = "lblmotorder";
            this.lblmotorder.Size = new System.Drawing.Size(18, 13);
            this.lblmotorder.TabIndex = 1;
            this.lblmotorder.Text = "🡩";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 362);
            this.Controls.Add(this.txtPorcentajeDer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPorcentajeIzq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsensor2estado);
            this.Controls.Add(this.txtsensor1estado);
            this.Controls.Add(this.panelsensor2);
            this.Controls.Add(this.panelsensor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAdelante);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelsensor1;
        private System.Windows.Forms.Panel panelsensor2;
        private System.Windows.Forms.Label txtsensor1estado;
        private System.Windows.Forms.Label txtsensor2estado;
        private System.Windows.Forms.Label txtPorcentajeIzq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtPorcentajeDer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmotorizq;
        private System.Windows.Forms.Label lblmotorder;
    }
}

