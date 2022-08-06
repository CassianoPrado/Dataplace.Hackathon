namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    partial class CancelarFehacrOrcamentosView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarFehacrOrcamentosView));
            this.gridOrcamento = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiMarcar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDesmarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAberto = new System.Windows.Forms.CheckBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkFechado = new System.Windows.Forms.CheckBox();
            this.rangeDate = new dpLibrary05.ucSymGen_ReferenceDtp();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.optFechar = new System.Windows.Forms.RadioButton();
            this.optCancelar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiasAVencer = new System.Windows.Forms.TextBox();
            this.txtDiasVencidos = new System.Windows.Forms.TextBox();
            this.chkOrcamentosAVencer = new System.Windows.Forms.CheckBox();
            this.chkOrcamentosVencidos = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dpiCliente = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiNumOrcamento = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.chkDataOrcamento = new System.Windows.Forms.CheckBox();
            this.optAbrirOrcamento = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrcamento
            // 
            this.gridOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrcamento.GroupByCaption = "Drag a column header here to group by that column";
            this.gridOrcamento.Images.Add(((System.Drawing.Image)(resources.GetObject("gridOrcamento.Images"))));
            this.gridOrcamento.Location = new System.Drawing.Point(3, 206);
            this.gridOrcamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridOrcamento.Name = "gridOrcamento";
            this.gridOrcamento.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.gridOrcamento.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.gridOrcamento.PreviewInfo.ZoomFactor = 75D;
            this.gridOrcamento.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.gridOrcamento.PrintInfo.MeasurementPrinterName = null;
            this.gridOrcamento.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("gridOrcamento.PrintInfo.PageSettings")));
            this.gridOrcamento.Size = new System.Drawing.Size(1341, 367);
            this.gridOrcamento.TabIndex = 3;
            this.gridOrcamento.UseCompatibleTextRendering = false;
            this.gridOrcamento.PropBag = resources.GetString("gridOrcamento.PropBag");
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(1233, 46);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(109, 30);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 683);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(122, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMarcar,
            this.tsiDesmarca,
            this.tsiExcel});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 24);
            this.toolStripSplitButton1.Text = "Ferramentas";
            // 
            // tsiMarcar
            // 
            this.tsiMarcar.Name = "tsiMarcar";
            this.tsiMarcar.Size = new System.Drawing.Size(220, 26);
            this.tsiMarcar.Text = "Marcar Todos";
            // 
            // tsiDesmarca
            // 
            this.tsiDesmarca.Name = "tsiDesmarca";
            this.tsiDesmarca.Size = new System.Drawing.Size(220, 26);
            this.tsiDesmarca.Text = "Desmarcar Todos";
            // 
            // tsiExcel
            // 
            this.tsiExcel.Name = "tsiExcel";
            this.tsiExcel.Size = new System.Drawing.Size(220, 26);
            this.tsiExcel.Text = "Exportar para excel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAberto);
            this.groupBox1.Controls.Add(this.chkCancelado);
            this.groupBox1.Controls.Add(this.chkFechado);
            this.groupBox1.Location = new System.Drawing.Point(497, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação do orçamento";
            // 
            // chkAberto
            // 
            this.chkAberto.AutoSize = true;
            this.chkAberto.Checked = true;
            this.chkAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAberto.Location = new System.Drawing.Point(15, 31);
            this.chkAberto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAberto.Name = "chkAberto";
            this.chkAberto.Size = new System.Drawing.Size(69, 20);
            this.chkAberto.TabIndex = 0;
            this.chkAberto.Text = "Aberto";
            this.chkAberto.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Location = new System.Drawing.Point(15, 79);
            this.chkCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(95, 20);
            this.chkCancelado.TabIndex = 2;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkFechado
            // 
            this.chkFechado.AutoSize = true;
            this.chkFechado.Location = new System.Drawing.Point(15, 55);
            this.chkFechado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFechado.Name = "chkFechado";
            this.chkFechado.Size = new System.Drawing.Size(83, 20);
            this.chkFechado.TabIndex = 1;
            this.chkFechado.Text = "Fechado";
            this.chkFechado.UseVisualStyleBackColor = true;
            // 
            // rangeDate
            // 
            this.rangeDate.Date1CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.Date2CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rangeDate.DotNetContainer = false;
            this.rangeDate.KeyPreview = false;
            this.rangeDate.Label1Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TFrom;
            this.rangeDate.Label2Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TTo;
            this.rangeDate.Location = new System.Drawing.Point(9, 50);
            this.rangeDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rangeDate.Name = "rangeDate";
            this.rangeDate.OpenModal = false;
            this.rangeDate.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("rangeDate.Parameters")));
            this.rangeDate.Size = new System.Drawing.Size(464, 27);
            this.rangeDate.TabIndex = 0;
            this.rangeDate.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.chkDataOrcamento);
            this.gbData.Controls.Add(this.rangeDate);
            this.gbData.Location = new System.Drawing.Point(4, 4);
            this.gbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbData.Size = new System.Drawing.Size(487, 113);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            // 
            // gbAcoes
            // 
            this.gbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAcoes.Controls.Add(this.optAbrirOrcamento);
            this.gbAcoes.Controls.Add(this.optFechar);
            this.gbAcoes.Controls.Add(this.optCancelar);
            this.gbAcoes.Location = new System.Drawing.Point(4, 580);
            this.gbAcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAcoes.Size = new System.Drawing.Size(1339, 87);
            this.gbAcoes.TabIndex = 4;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "O que deseja fazer?";
            // 
            // optFechar
            // 
            this.optFechar.AutoSize = true;
            this.optFechar.Checked = true;
            this.optFechar.Location = new System.Drawing.Point(32, 42);
            this.optFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optFechar.Name = "optFechar";
            this.optFechar.Size = new System.Drawing.Size(137, 20);
            this.optFechar.TabIndex = 0;
            this.optFechar.Text = "Fechar orçamento";
            this.optFechar.UseVisualStyleBackColor = true;
            // 
            // optCancelar
            // 
            this.optCancelar.AutoSize = true;
            this.optCancelar.Location = new System.Drawing.Point(32, 18);
            this.optCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optCancelar.Name = "optCancelar";
            this.optCancelar.Size = new System.Drawing.Size(149, 20);
            this.optCancelar.TabIndex = 6;
            this.optCancelar.Text = "Cancelar orçamento";
            this.optCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOrcamentosVencidos);
            this.groupBox2.Controls.Add(this.chkOrcamentosAVencer);
            this.groupBox2.Controls.Add(this.txtDiasVencidos);
            this.groupBox2.Controls.Add(this.txtDiasAVencer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(676, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(550, 113);
            this.groupBox2.TabIndex = 501;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situação do Vencimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "dias a vencer";
            // 
            // txtDiasAVencer
            // 
            this.txtDiasAVencer.Location = new System.Drawing.Point(174, 32);
            this.txtDiasAVencer.Name = "txtDiasAVencer";
            this.txtDiasAVencer.Size = new System.Drawing.Size(44, 22);
            this.txtDiasAVencer.TabIndex = 2;
            // 
            // txtDiasVencidos
            // 
            this.txtDiasVencidos.Location = new System.Drawing.Point(214, 67);
            this.txtDiasVencidos.Name = "txtDiasVencidos";
            this.txtDiasVencidos.Size = new System.Drawing.Size(44, 22);
            this.txtDiasVencidos.TabIndex = 5;
            // 
            // chkOrcamentosAVencer
            // 
            this.chkOrcamentosAVencer.AutoSize = true;
            this.chkOrcamentosAVencer.Location = new System.Drawing.Point(16, 34);
            this.chkOrcamentosAVencer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOrcamentosAVencer.Name = "chkOrcamentosAVencer";
            this.chkOrcamentosAVencer.Size = new System.Drawing.Size(131, 20);
            this.chkOrcamentosAVencer.TabIndex = 6;
            this.chkOrcamentosAVencer.Text = "Orçamentos com";
            this.chkOrcamentosAVencer.UseVisualStyleBackColor = true;
            // 
            // chkOrcamentosVencidos
            // 
            this.chkOrcamentosVencidos.AutoSize = true;
            this.chkOrcamentosVencidos.Location = new System.Drawing.Point(16, 69);
            this.chkOrcamentosVencidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOrcamentosVencidos.Name = "chkOrcamentosVencidos";
            this.chkOrcamentosVencidos.Size = new System.Drawing.Size(171, 20);
            this.chkOrcamentosVencidos.TabIndex = 7;
            this.chkOrcamentosVencidos.Text = "Orçamentos vencidos à";
            this.chkOrcamentosVencidos.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dpiCliente);
            this.groupBox3.Controls.Add(this.dpiNumOrcamento);
            this.groupBox3.Location = new System.Drawing.Point(4, 123);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1222, 79);
            this.groupBox3.TabIndex = 502;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar Oçamento Induvidual ou Por Cliente:";
            // 
            // dpiCliente
            // 
            this.dpiCliente.Active = false;
            this.dpiCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiCliente.DataSource = null;
            this.dpiCliente.DP_Caption = null;
            this.dpiCliente.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Hide;
            this.dpiCliente.DP_DataField = null;
            this.dpiCliente.DP_FilterMemo = false;
            this.dpiCliente.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpiCliente.DP_Length = 0;
            this.dpiCliente.DP_Maximum = null;
            this.dpiCliente.DP_Minimum = null;
            this.dpiCliente.DP_NumericPrecision = 0;
            this.dpiCliente.EditMask = null;
            this.dpiCliente.EditMaskUpdate = false;
            this.dpiCliente.FindMode = false;
            this.dpiCliente.InterfaceField = null;
            this.dpiCliente.IsReadonly = false;
            this.dpiCliente.Location = new System.Drawing.Point(109, 21);
            this.dpiCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dpiCliente.Multiline = false;
            this.dpiCliente.Name = "dpiCliente";
            this.dpiCliente.SearchObject = null;
            this.dpiCliente.SettingValue = false;
            this.dpiCliente.Size = new System.Drawing.Size(467, 44);
            this.dpiCliente.TabIndex = 3;
            // 
            // dpiNumOrcamento
            // 
            this.dpiNumOrcamento.Active = false;
            this.dpiNumOrcamento.DataSource = null;
            this.dpiNumOrcamento.DP_Caption = "3182";
            this.dpiNumOrcamento.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiNumOrcamento.DP_DataField = null;
            this.dpiNumOrcamento.DP_FilterMemo = false;
            this.dpiNumOrcamento.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.StringInput;
            this.dpiNumOrcamento.DP_Length = 0;
            this.dpiNumOrcamento.DP_Maximum = null;
            this.dpiNumOrcamento.DP_Minimum = null;
            this.dpiNumOrcamento.DP_NumericPrecision = 0;
            this.dpiNumOrcamento.EditMask = null;
            this.dpiNumOrcamento.EditMaskUpdate = false;
            this.dpiNumOrcamento.FindMode = false;
            this.dpiNumOrcamento.InterfaceField = null;
            this.dpiNumOrcamento.IsReadonly = false;
            this.dpiNumOrcamento.Location = new System.Drawing.Point(9, 25);
            this.dpiNumOrcamento.Margin = new System.Windows.Forms.Padding(4);
            this.dpiNumOrcamento.Multiline = false;
            this.dpiNumOrcamento.Name = "dpiNumOrcamento";
            this.dpiNumOrcamento.SearchObject = null;
            this.dpiNumOrcamento.SettingValue = false;
            this.dpiNumOrcamento.Size = new System.Drawing.Size(92, 44);
            this.dpiNumOrcamento.TabIndex = 2;
            // 
            // chkDataOrcamento
            // 
            this.chkDataOrcamento.AutoSize = true;
            this.chkDataOrcamento.Checked = true;
            this.chkDataOrcamento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataOrcamento.Location = new System.Drawing.Point(10, 1);
            this.chkDataOrcamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDataOrcamento.Name = "chkDataOrcamento";
            this.chkDataOrcamento.Size = new System.Drawing.Size(146, 20);
            this.chkDataOrcamento.TabIndex = 2;
            this.chkDataOrcamento.Text = "Data do Orçamento";
            this.chkDataOrcamento.UseVisualStyleBackColor = true;
            // 
            // optAbrirOrcamento
            // 
            this.optAbrirOrcamento.AutoSize = true;
            this.optAbrirOrcamento.Location = new System.Drawing.Point(32, 67);
            this.optAbrirOrcamento.Margin = new System.Windows.Forms.Padding(4);
            this.optAbrirOrcamento.Name = "optAbrirOrcamento";
            this.optAbrirOrcamento.Size = new System.Drawing.Size(123, 20);
            this.optAbrirOrcamento.TabIndex = 7;
            this.optAbrirOrcamento.Text = "Abrir orçamento";
            this.optAbrirOrcamento.UseVisualStyleBackColor = true;
            // 
            // CancelarFehacrOrcamentosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.gridOrcamento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CancelarFehacrOrcamentosView";
            this.Size = new System.Drawing.Size(1347, 750);
            this.Controls.SetChildIndex(this.gridOrcamento, 0);
            this.Controls.SetChildIndex(this.btnCarregar, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.gbAcoes, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbAcoes.ResumeLayout(false);
            this.gbAcoes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid gridOrcamento;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsiMarcar;
        private System.Windows.Forms.ToolStripMenuItem tsiDesmarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAberto;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.CheckBox chkFechado;
        private System.Windows.Forms.ToolStripMenuItem tsiExcel;
        internal dpLibrary05.ucSymGen_ReferenceDtp rangeDate;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.RadioButton optFechar;
        private System.Windows.Forms.RadioButton optCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiasVencidos;
        private System.Windows.Forms.TextBox txtDiasAVencer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOrcamentosVencidos;
        private System.Windows.Forms.CheckBox chkOrcamentosAVencer;
        private System.Windows.Forms.GroupBox groupBox3;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiCliente;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiNumOrcamento;
        private System.Windows.Forms.CheckBox chkDataOrcamento;
        private System.Windows.Forms.RadioButton optAbrirOrcamento;
    }
}
