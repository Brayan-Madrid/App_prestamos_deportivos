using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_prestamos : Form
    {
        public frm_prestamos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_nombre.Clear();
            txt_codigo_implemento.Clear();
            txt_descripcion.Clear();
            txt_existencia.Clear();
            txt_nombre_implemento.Clear();
            txt_cantidad_prestamo.Clear();
            txt_observaciones.Clear();
            dtg_prestamo.DataSource = null;
            txt_id.Focus();
        }
    }
}
