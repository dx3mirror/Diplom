using System.ComponentModel;
using System.Windows.Forms;

namespace Examen.Components
{
    public partial class RoundingButtonsComponent : Component
    {
        public Form TargetForm { get; set; }

        private bool roundingEnable = false;
        [Description("���/���� ����������� �������")]
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Update();
            }
        }

        private int roundingPercent = 100;
        [DisplayName("Rounding [%]")]
        [DefaultValue(100)]
        [Description("��������� ������ ����������� ������� � ���������� �����������")]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;

                    Update();
                }
            }
        }

        [DefaultValue(true)]
        [Description("��������� ����������� ��� ��������� �����������")]
        public bool NestedContainers { get; set; } = true;

        public RoundingButtonsComponent()
        {
            InitializeComponent();
        }

        public RoundingButtonsComponent(IContainer container)
        {
            Update();

            container.Add(this);

            InitializeComponent();
        }

        public void Update()
        {
            if(TargetForm != null && TargetForm.Controls.Count > 0)
            {
                DefineRounding(TargetForm.Controls);
            }
        }

        public void DefineRounding(Control.ControlCollection controls)
        {
            foreach(Control ctrl in controls)
            {
                if(ctrl is yt_Button)
                {
                    yt_Button btn = (yt_Button)ctrl;

                    btn.RoundingEnable = RoundingEnable;
                    btn.Rounding = Rounding;

                    btn.Refresh();
                }

                if (NestedContainers)
                {
                    if(ctrl.Controls.Count > 0)
                    {
                        DefineRounding(ctrl.Controls);
                    }
                }
            }
        }
    }
}
