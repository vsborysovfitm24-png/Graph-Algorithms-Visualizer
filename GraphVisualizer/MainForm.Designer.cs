namespace GraphVisualizer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdgeFrom = new System.Windows.Forms.TextBox();
            this.txtEdgeTo = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartVertex = new System.Windows.Forms.TextBox();
            this.btnRunBFS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGraphInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вершина:";
            // 
            // txtVertex
            // 
            this.txtVertex.Location = new System.Drawing.Point(42, 88);
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.Size = new System.Drawing.Size(100, 20);
            this.txtVertex.TabIndex = 1;
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(42, 141);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(131, 23);
            this.btnAddVertex.TabIndex = 2;
            this.btnAddVertex.Text = "Додати вершину";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ребро:";
            // 
            // txtEdgeFrom
            // 
            this.txtEdgeFrom.Location = new System.Drawing.Point(286, 88);
            this.txtEdgeFrom.Name = "txtEdgeFrom";
            this.txtEdgeFrom.Size = new System.Drawing.Size(100, 20);
            this.txtEdgeFrom.TabIndex = 4;
            // 
            // txtEdgeTo
            // 
            this.txtEdgeTo.Location = new System.Drawing.Point(286, 132);
            this.txtEdgeTo.Name = "txtEdgeTo";
            this.txtEdgeTo.Size = new System.Drawing.Size(100, 20);
            this.txtEdgeTo.TabIndex = 5;
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(286, 187);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(131, 23);
            this.btnAddEdge.TabIndex = 6;
            this.btnAddEdge.Text = "Додати ребро";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Старт BFS:";
            // 
            // txtStartVertex
            // 
            this.txtStartVertex.Location = new System.Drawing.Point(554, 88);
            this.txtStartVertex.Name = "txtStartVertex";
            this.txtStartVertex.Size = new System.Drawing.Size(100, 20);
            this.txtStartVertex.TabIndex = 8;
            // 
            // btnRunBFS
            // 
            this.btnRunBFS.Location = new System.Drawing.Point(554, 141);
            this.btnRunBFS.Name = "btnRunBFS";
            this.btnRunBFS.Size = new System.Drawing.Size(131, 23);
            this.btnRunBFS.TabIndex = 9;
            this.btnRunBFS.Text = "Запустити BFS";
            this.btnRunBFS.UseVisualStyleBackColor = true;
            this.btnRunBFS.Click += new System.EventHandler(this.btnRunBFS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результат обходу:";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(792, 88);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(120, 95);
            this.lstResults.TabIndex = 11;
            // 
            // pnlGraph
            // 
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(12, 255);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(1060, 444);
            this.pnlGraph.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(951, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Очистити граф";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGraphInfo
            // 
            this.btnGraphInfo.Location = new System.Drawing.Point(951, 153);
            this.btnGraphInfo.Name = "btnGraphInfo";
            this.btnGraphInfo.Size = new System.Drawing.Size(130, 30);
            this.btnGraphInfo.TabIndex = 14;
            this.btnGraphInfo.Text = "Інформація про граф";
            this.btnGraphInfo.UseVisualStyleBackColor = true;
            this.btnGraphInfo.Click += new System.EventHandler(this.btnGraphInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.btnGraphInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRunBFS);
            this.Controls.Add(this.txtStartVertex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.txtEdgeTo);
            this.Controls.Add(this.txtEdgeFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddVertex);
            this.Controls.Add(this.txtVertex);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BFS Graph Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdgeFrom;
        private System.Windows.Forms.TextBox txtEdgeTo;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartVertex;
        private System.Windows.Forms.Button btnRunBFS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGraphInfo;
    }
}

