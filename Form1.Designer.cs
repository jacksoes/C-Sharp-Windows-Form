namespace homeword_9._21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_costof = new Label();
            label_labor = new Label();
            box_labor = new TextBox();
            label_material = new Label();
            box_material = new TextBox();
            box_subtotal = new TextBox();
            label_subtotal = new Label();
            label_salestax = new Label();
            box_salestax = new TextBox();
            label_totalcost = new Label();
            box_totalcost = new TextBox();
            button_computecost = new Button();
            listbox_states = new ListBox();
            SuspendLayout();
            // 
            // label_costof
            // 
            label_costof.AutoSize = true;
            label_costof.Location = new Point(12, 26);
            label_costof.Name = "label_costof";
            label_costof.Size = new Size(48, 15);
            label_costof.TabIndex = 0;
            label_costof.Text = "Cost of:";
            label_costof.Click += label1_Click;
            // 
            // label_labor
            // 
            label_labor.AutoSize = true;
            label_labor.Location = new Point(23, 59);
            label_labor.Name = "label_labor";
            label_labor.Size = new Size(37, 15);
            label_labor.TabIndex = 1;
            label_labor.Text = "Labor";
            // 
            // box_labor
            // 
            box_labor.Location = new Point(77, 59);
            box_labor.Name = "box_labor";
            box_labor.Size = new Size(100, 23);
            box_labor.TabIndex = 2;
            // 
            // label_material
            // 
            label_material.AutoSize = true;
            label_material.Location = new Point(23, 92);
            label_material.Name = "label_material";
            label_material.Size = new Size(50, 15);
            label_material.TabIndex = 3;
            label_material.Text = "Material";
            label_material.Click += label1_Click_1;
            // 
            // box_material
            // 
            box_material.Location = new Point(77, 89);
            box_material.Name = "box_material";
            box_material.Size = new Size(100, 23);
            box_material.TabIndex = 4;
            // 
            // box_subtotal
            // 
            box_subtotal.Location = new Point(77, 265);
            box_subtotal.Name = "box_subtotal";
            box_subtotal.Size = new Size(100, 23);
            box_subtotal.TabIndex = 5;
            box_subtotal.TextChanged += box_subtotal_TextChanged;
            // 
            // label_subtotal
            // 
            label_subtotal.AutoSize = true;
            label_subtotal.Location = new Point(14, 268);
            label_subtotal.Name = "label_subtotal";
            label_subtotal.Size = new Size(51, 15);
            label_subtotal.TabIndex = 6;
            label_subtotal.Text = "Subtotal";
            // 
            // label_salestax
            // 
            label_salestax.AutoSize = true;
            label_salestax.Location = new Point(12, 337);
            label_salestax.Name = "label_salestax";
            label_salestax.Size = new Size(53, 15);
            label_salestax.TabIndex = 7;
            label_salestax.Text = "Sales Tax";
            // 
            // box_salestax
            // 
            box_salestax.Location = new Point(77, 329);
            box_salestax.Name = "box_salestax";
            box_salestax.Size = new Size(100, 23);
            box_salestax.TabIndex = 8;
            // 
            // label_totalcost
            // 
            label_totalcost.AutoSize = true;
            label_totalcost.Location = new Point(6, 400);
            label_totalcost.Name = "label_totalcost";
            label_totalcost.Size = new Size(59, 15);
            label_totalcost.TabIndex = 9;
            label_totalcost.Text = "Total Cost";
            // 
            // box_totalcost
            // 
            box_totalcost.Location = new Point(77, 392);
            box_totalcost.Name = "box_totalcost";
            box_totalcost.Size = new Size(100, 23);
            box_totalcost.TabIndex = 10;
            // 
            // button_computecost
            // 
            button_computecost.Location = new Point(77, 159);
            button_computecost.Name = "button_computecost";
            button_computecost.Size = new Size(75, 50);
            button_computecost.TabIndex = 11;
            button_computecost.Text = "Compute Cost";
            button_computecost.UseVisualStyleBackColor = true;
            button_computecost.Click += button_click;
            // 
            // listbox_states
            // 
            listbox_states.FormattingEnabled = true;
            listbox_states.ItemHeight = 15;
            listbox_states.Location = new Point(303, 26);
            listbox_states.Name = "listbox_states";
            listbox_states.Size = new Size(269, 274);
            listbox_states.TabIndex = 12;
            listbox_states.SelectedIndexChanged += listbox_states_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listbox_states);
            Controls.Add(button_computecost);
            Controls.Add(box_totalcost);
            Controls.Add(label_totalcost);
            Controls.Add(box_salestax);
            Controls.Add(label_salestax);
            Controls.Add(label_subtotal);
            Controls.Add(box_subtotal);
            Controls.Add(box_material);
            Controls.Add(label_material);
            Controls.Add(box_labor);
            Controls.Add(label_labor);
            Controls.Add(label_costof);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_costof;
        private Label label_labor;
        private TextBox box_labor;
        private Label label_material;
        private TextBox box_material;
        private TextBox box_subtotal;
        private Label label_subtotal;
        private Label label_salestax;
        private TextBox box_salestax;
        private Label label_totalcost;
        private TextBox box_totalcost;
        private Button button_computecost;
        private ListBox listbox_states;
    }
}