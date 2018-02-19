﻿namespace WFA_ListagemPesquisas
{
    partial class SmartViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartViewer));
            this.spltContCtrlSmartViewer = new DevExpress.XtraEditors.SplitContainerControl();
            this.trLstSmartViewer = new DevExpress.XtraTreeList.TreeList();
            this.trLstClmImagem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.rpstryItmImgCmbBxImagem = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imgClctnSmartViewer = new DevExpress.Utils.ImageCollection(this.components);
            this.trLstClmTitulo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dtStSmartViewer = new System.Data.DataSet();
            this.dtTblTblTreeList = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.tlTpCtrlrSmartViewer = new DevExpress.Utils.ToolTipController(this.components);
            this.xtrTbCtrlSmartViewer = new DevExpress.XtraTab.XtraTabControl();
            this.xtrTbPgAgarde = new DevExpress.XtraTab.XtraTabPage();
            this.tblLytPnlAguarde = new System.Windows.Forms.TableLayoutPanel();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.xtrTbPgInicial = new DevExpress.XtraTab.XtraTabPage();
            this.tblLytPnlInicial = new System.Windows.Forms.TableLayoutPanel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spltContCtrlSmartViewer)).BeginInit();
            this.spltContCtrlSmartViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trLstSmartViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstryItmImgCmbBxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClctnSmartViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStSmartViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTblTblTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrTbCtrlSmartViewer)).BeginInit();
            this.xtrTbCtrlSmartViewer.SuspendLayout();
            this.xtrTbPgAgarde.SuspendLayout();
            this.tblLytPnlAguarde.SuspendLayout();
            this.xtrTbPgInicial.SuspendLayout();
            this.tblLytPnlInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spltContCtrlSmartViewer
            // 
            this.spltContCtrlSmartViewer.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            resources.ApplyResources(this.spltContCtrlSmartViewer, "spltContCtrlSmartViewer");
            this.spltContCtrlSmartViewer.Name = "spltContCtrlSmartViewer";
            this.spltContCtrlSmartViewer.Panel1.Controls.Add(this.trLstSmartViewer);
            resources.ApplyResources(this.spltContCtrlSmartViewer.Panel1, "spltContCtrlSmartViewer.Panel1");
            this.spltContCtrlSmartViewer.Panel2.Controls.Add(this.xtrTbCtrlSmartViewer);
            resources.ApplyResources(this.spltContCtrlSmartViewer.Panel2, "spltContCtrlSmartViewer.Panel2");
            this.spltContCtrlSmartViewer.SplitterPosition = 305;
            // 
            // trLstSmartViewer
            // 
            this.trLstSmartViewer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.trLstSmartViewer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.trLstClmImagem,
            this.trLstClmTitulo});
            resources.ApplyResources(this.trLstSmartViewer, "trLstSmartViewer");
            this.trLstSmartViewer.DataSource = this.dtStSmartViewer;
            this.trLstSmartViewer.KeyFieldName = "Titulo";
            this.trLstSmartViewer.Name = "trLstSmartViewer";
            this.trLstSmartViewer.OptionsBehavior.Editable = false;
            this.trLstSmartViewer.OptionsBehavior.EnableFiltering = true;
            this.trLstSmartViewer.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.trLstSmartViewer.OptionsMenu.EnableFooterMenu = false;
            this.trLstSmartViewer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.trLstSmartViewer.OptionsView.ShowAutoFilterRow = true;
            this.trLstSmartViewer.OptionsView.ShowColumns = false;
            this.trLstSmartViewer.OptionsView.ShowFocusedFrame = false;
            this.trLstSmartViewer.OptionsView.ShowHorzLines = false;
            this.trLstSmartViewer.OptionsView.ShowIndicator = false;
            this.trLstSmartViewer.OptionsView.ShowSummaryFooter = true;
            this.trLstSmartViewer.OptionsView.ShowVertLines = false;
            this.trLstSmartViewer.ParentFieldName = "ParentTitulo";
            this.trLstSmartViewer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpstryItmImgCmbBxImagem});
            this.trLstSmartViewer.ToolTipController = this.tlTpCtrlrSmartViewer;
            this.trLstSmartViewer.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.trLstSmartViewer_GetStateImage);
            this.trLstSmartViewer.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.trLstSmartViewer_FocusedNodeChanged);
            this.trLstSmartViewer.DoubleClick += new System.EventHandler(this.trLstSmartViewer_DoubleClick);
            // 
            // trLstClmImagem
            // 
            resources.ApplyResources(this.trLstClmImagem, "trLstClmImagem");
            this.trLstClmImagem.ColumnEdit = this.rpstryItmImgCmbBxImagem;
            this.trLstClmImagem.FieldName = "Imagem";
            this.trLstClmImagem.Name = "trLstClmImagem";
            this.trLstClmImagem.OptionsColumn.FixedWidth = true;
            // 
            // rpstryItmImgCmbBxImagem
            // 
            resources.ApplyResources(this.rpstryItmImgCmbBxImagem, "rpstryItmImgCmbBxImagem");
            this.rpstryItmImgCmbBxImagem.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("rpstryItmImgCmbBxImagem.Items"), ((object)(resources.GetObject("rpstryItmImgCmbBxImagem.Items1"))), ((int)(resources.GetObject("rpstryItmImgCmbBxImagem.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("rpstryItmImgCmbBxImagem.Items3"), ((object)(resources.GetObject("rpstryItmImgCmbBxImagem.Items4"))), ((int)(resources.GetObject("rpstryItmImgCmbBxImagem.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("rpstryItmImgCmbBxImagem.Items6"), ((object)(resources.GetObject("rpstryItmImgCmbBxImagem.Items7"))), ((int)(resources.GetObject("rpstryItmImgCmbBxImagem.Items8")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("rpstryItmImgCmbBxImagem.Items9"), ((object)(resources.GetObject("rpstryItmImgCmbBxImagem.Items10"))), ((int)(resources.GetObject("rpstryItmImgCmbBxImagem.Items11")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("rpstryItmImgCmbBxImagem.Items12"), ((object)(resources.GetObject("rpstryItmImgCmbBxImagem.Items13"))), ((int)(resources.GetObject("rpstryItmImgCmbBxImagem.Items14")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("rpstryItmImgCmbBxImagem.Items15"), ((object)(resources.GetObject("rpstryItmImgCmbBxImagem.Items16"))), ((int)(resources.GetObject("rpstryItmImgCmbBxImagem.Items17")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("rpstryItmImgCmbBxImagem.Items18"), ((object)(resources.GetObject("rpstryItmImgCmbBxImagem.Items19"))), ((int)(resources.GetObject("rpstryItmImgCmbBxImagem.Items20"))))});
            this.rpstryItmImgCmbBxImagem.LargeImages = this.imgClctnSmartViewer;
            this.rpstryItmImgCmbBxImagem.Name = "rpstryItmImgCmbBxImagem";
            // 
            // imgClctnSmartViewer
            // 
            resources.ApplyResources(this.imgClctnSmartViewer, "imgClctnSmartViewer");
            this.imgClctnSmartViewer.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgClctnSmartViewer.ImageStream")));
            this.imgClctnSmartViewer.Images.SetKeyName(0, "icone_pasta_fechada.png");
            this.imgClctnSmartViewer.Images.SetKeyName(1, "icone_pasta_aberta.png");
            this.imgClctnSmartViewer.Images.SetKeyName(2, "icone_pasta_fechada_numtem.png");
            this.imgClctnSmartViewer.Images.SetKeyName(3, "icone_blank.png");
            this.imgClctnSmartViewer.Images.SetKeyName(4, "icone_tem.png");
            this.imgClctnSmartViewer.Images.SetKeyName(5, "icone_espera.png");
            this.imgClctnSmartViewer.Images.SetKeyName(6, "icone_naotem.png");
            // 
            // trLstClmTitulo
            // 
            resources.ApplyResources(this.trLstClmTitulo, "trLstClmTitulo");
            this.trLstClmTitulo.FieldName = "Titulo";
            this.trLstClmTitulo.Name = "trLstClmTitulo";
            // 
            // dtStSmartViewer
            // 
            this.dtStSmartViewer.DataSetName = "NewDataSet";
            this.dtStSmartViewer.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTblTblTreeList});
            // 
            // dtTblTblTreeList
            // 
            this.dtTblTblTreeList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn1,
            this.dataColumn7,
            this.dataColumn8});
            this.dtTblTblTreeList.TableName = "TblTreeList";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Titulo";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Pesquisa";
            this.dataColumn4.DataType = typeof(object);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ParentTitulo";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Arquivo";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Imagem";
            this.dataColumn8.DataType = typeof(int);
            this.dataColumn8.DefaultValue = 0;
            // 
            // tlTpCtrlrSmartViewer
            // 
            this.tlTpCtrlrSmartViewer.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // xtrTbCtrlSmartViewer
            // 
            this.xtrTbCtrlSmartViewer.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("xtrTbCtrlSmartViewer.Appearance.BackColor")));
            this.xtrTbCtrlSmartViewer.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.xtrTbCtrlSmartViewer, "xtrTbCtrlSmartViewer");
            this.xtrTbCtrlSmartViewer.Name = "xtrTbCtrlSmartViewer";
            this.xtrTbCtrlSmartViewer.SelectedTabPage = this.xtrTbPgAgarde;
            this.xtrTbCtrlSmartViewer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtrTbPgAgarde,
            this.xtrTbPgInicial});
            // 
            // xtrTbPgAgarde
            // 
            this.xtrTbPgAgarde.Controls.Add(this.tblLytPnlAguarde);
            this.xtrTbPgAgarde.Name = "xtrTbPgAgarde";
            resources.ApplyResources(this.xtrTbPgAgarde, "xtrTbPgAgarde");
            // 
            // tblLytPnlAguarde
            // 
            resources.ApplyResources(this.tblLytPnlAguarde, "tblLytPnlAguarde");
            this.tblLytPnlAguarde.Controls.Add(this.progressPanel1, 1, 1);
            this.tblLytPnlAguarde.Name = "tblLytPnlAguarde";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("progressPanel1.Appearance.BackColor")));
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Caption = "Por favor, aguarde!";
            this.progressPanel1.Description = "Atualizando dados...";
            resources.ApplyResources(this.progressPanel1, "progressPanel1");
            this.progressPanel1.Name = "progressPanel1";
            // 
            // xtrTbPgInicial
            // 
            this.xtrTbPgInicial.Controls.Add(this.tblLytPnlInicial);
            this.xtrTbPgInicial.Name = "xtrTbPgInicial";
            resources.ApplyResources(this.xtrTbPgInicial, "xtrTbPgInicial");
            // 
            // tblLytPnlInicial
            // 
            this.tblLytPnlInicial.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tblLytPnlInicial, "tblLytPnlInicial");
            this.tblLytPnlInicial.Controls.Add(this.pictureEdit1, 1, 1);
            this.tblLytPnlInicial.Name = "tblLytPnlInicial";
            // 
            // pictureEdit1
            // 
            resources.ApplyResources(this.pictureEdit1, "pictureEdit1");
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("pictureEdit1.Properties.Appearance.BackColor")));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // SmartViewer
            // 
            this.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("SmartViewer.Appearance.ForeColor")));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spltContCtrlSmartViewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmartViewer";
            this.Tag = "Smart viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SmartViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spltContCtrlSmartViewer)).EndInit();
            this.spltContCtrlSmartViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trLstSmartViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstryItmImgCmbBxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClctnSmartViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStSmartViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTblTblTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrTbCtrlSmartViewer)).EndInit();
            this.xtrTbCtrlSmartViewer.ResumeLayout(false);
            this.xtrTbPgAgarde.ResumeLayout(false);
            this.tblLytPnlAguarde.ResumeLayout(false);
            this.xtrTbPgInicial.ResumeLayout(false);
            this.tblLytPnlInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtrTbCtrlSmartViewer;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.TableLayoutPanel tblLytPnlAguarde;
        private DevExpress.XtraTab.XtraTabPage xtrTbPgAgarde;
        private DevExpress.XtraTreeList.TreeList trLstSmartViewer;
        private System.Data.DataSet dtStSmartViewer;
        private System.Data.DataTable dtTblTblTreeList;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private DevExpress.XtraEditors.SplitContainerControl spltContCtrlSmartViewer;
        private System.Windows.Forms.TableLayoutPanel tblLytPnlInicial;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraTab.XtraTabPage xtrTbPgInicial;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private DevExpress.Utils.ImageCollection imgClctnSmartViewer;
        private DevExpress.Utils.ToolTipController tlTpCtrlrSmartViewer;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox rpstryItmImgCmbBxImagem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trLstClmImagem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trLstClmTitulo;

    }
}
