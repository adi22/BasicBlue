using System;
using BasicBlue.SzachyBasicBlue;
namespace SzachyBasicBlue {
	public class Pionek : Bierka  {
		/// <summary>
		/// Pionek mo�e porusza� si� tylko do przodu, a bij�c na skos
		/// </summary>
		public Enums.KierunekRuchu Kierunek_Ruchu;
		private bool promocja;
		private Pionki_Gracza promocja_Do;

	}

}
