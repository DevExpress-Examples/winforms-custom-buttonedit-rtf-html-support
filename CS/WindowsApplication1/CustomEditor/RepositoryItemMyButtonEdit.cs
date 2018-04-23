using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1
{
    [UserRepositoryItem("Register")]

    [System.ComponentModel.DesignerCategory("")]
    public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit
    {
                private RepositoryItemRichTextEdit _RichRI = new RepositoryItemRichTextEdit();
        public RepositoryItemRichTextEdit RichEdit
        {
            get { return _RichRI; }
            set { _RichRI = value; }
        }

        static RepositoryItemMyButtonEdit()
        {
            Register();
        }
        public RepositoryItemMyButtonEdit() { }

        internal const string EditorName = "MyButtonEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit),
                typeof(RepositoryItemMyButtonEdit), typeof(MyButtonEditViewInfo),
                new MyPainter(), true, null));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        public override TextEditStyles TextEditStyle
        {
            get
            {
                return TextEditStyles.DisableTextEditor;
            }
            set
            {

            }
        }

        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            RichEdit.Assign((item as RepositoryItemMyButtonEdit).RichEdit);
        }


    }
}
