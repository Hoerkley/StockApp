using StockApp.Business.Entidade;
using StockApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.WindowsForms.Cadastros
{
    public partial class frmCategoria : Form
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public frmCategoria()
        {
            InitializeComponent();
        }
        public frmCategoria(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novaCaegoria = new Categoria();
            novaCaegoria.Nome = txtCategoria.Text;
            novaCaegoria.Status = chkStatus.Checked;

           var resultado = _categoriaRepository.Incluir(novaCaegoria);
           if (resultado)
           {
               MessageBox.Show("Cadastro realizado!!");
           }
           else
           {
               MessageBox.Show("Está errado");
           }
        }
    }
}
