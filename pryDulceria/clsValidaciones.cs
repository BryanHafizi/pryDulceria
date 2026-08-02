using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace pryDulceria
{
    internal class clsValidaciones
    {
        // SOLO ALFANUMÉRICO (Para Nombres de Productos, Direcciones, etc.)
        public static void Alfanumerico(KeyPressEventArgs e)
        {
            // Permite letras, números, teclas de control y espacios en blanco
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea caracteres especiales raros (como @, %, etc.)
            }
        }
        //SOLO NÚMEROS ENTEROS (Para Cantidades, Stock, Teléfonos)
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            // Permite solo números (0-9) y teclas de control como Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
        //NÚMEROS CON DECIMALES (Para Precios, Montos, Totales)
        public static void SoloDecimales(object sender, KeyPressEventArgs e)
        {
            // Permite números, control y el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Evita que escriban más de un punto decimal
            TextBox txt = sender as TextBox;
            if ((e.KeyChar == '.') && (txt != null) && (txt.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        // SOLO LETRAS (Para Nombres, Apellidos, Categorias,etc)
        public static void SoloLetras(KeyPressEventArgs e)
        {
            // Permite letras, teclas de control y espacios en blanco
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // VALIDAR CAMPO VACÍO (Retorna true si está vacío)
        public static bool EstaVacio(TextBox txt, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede estar vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus(); // Pone el cursor en esa caja
                return true;
            }
            return false;
        }
        // VALIDAR FORMATO DE EMAIL (user@email.com)
        public static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            // Expresión regular estándar para correos
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }
    }
}