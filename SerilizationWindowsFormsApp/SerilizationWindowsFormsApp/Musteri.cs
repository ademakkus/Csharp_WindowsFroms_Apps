using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilizationWindowsFormsApp
{
  [Serializable]
  class Musteri
  {
    private string _ad;
    private string _soyad;
    private string _email;
    private string _telefon;

    public string Ad { get => _ad; set => _ad = value; }
    public string Soyad { get => _soyad; set => _soyad = value; }
    public string Email { get => _email; set => _email = value; }
    public string Telefon { get => _telefon; set => _telefon = value; }
  }
}
