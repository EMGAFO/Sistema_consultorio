﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    class Validacion
    {

		#region SoloLetras
		////////////////////////////////////////////////////////////////
		public void sololetras(KeyPressEventArgs e)
		{
			try
			{
				if (char.IsLetter(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (char.IsControl(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (char.IsSeparator(e.KeyChar))
				{
					e.Handled = false;
				}
				else
				{
					e.Handled = true;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);

			}
		}
		///////////////////////////////////////////////////////////////////// 
		#endregion

		#region SoloNumero
		public void soloNumeros(KeyPressEventArgs e)
		{
			try
			{
				if (char.IsNumber(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (char.IsControl(e.KeyChar))
				{
					e.Handled = false;
				}
				else if (char.IsSeparator(e.KeyChar))
				{
					e.Handled = false;
				}
				else
				{
					e.Handled = true;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: "+ex.Message);

			}
		} 
		#endregion

	}
}
