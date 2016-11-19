using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pretplatnici2_DAL;

namespace Pretplatnici2_UI
{
    public partial class DodajPretplatnika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            NapuniSS();
            }
        }

            private void NapuniSS()
            {
                List<StrucnaSprema> lista = Service_DA.StrucneSpremeSelectAll();
                StrucnaSprema prazno = new StrucnaSprema();

                prazno.StrucnaSpremaID = 0;
                prazno.Skracenica = "-";
                prazno.Naziv = "-";

                lista.Insert(0, prazno);
                ddlStrucneSpreme.DataSource = lista;
                ddlStrucneSpreme.DataValueField = "StrucnaSpremaID";
                ddlStrucneSpreme.DataTextField = "Skracenica";
                ddlStrucneSpreme.DataBind();
            }

            protected void Sacuvaj_Click(object sender, EventArgs e)
            {
                Pretplatnici p = new Pretplatnici();
                p.Ime = txtIme.Text;
                p.Prezime = txtPrezime.Text;
                p.KorisnickoIme = txtKorisnickoIme.Text;
                p.Lozinka = txtLozinka.Text;
                p.Email = txtEmail.Text;
                p.StrucnaSpremaID = Convert.ToInt16(ddlStrucneSpreme.SelectedValue.ToString());

                Pretplatnici2_DAL.Service_DA.InsertPretplatnik(p);
        }
        }
    
}