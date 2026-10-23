using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mantenimiento;

public static class Lanzador
{
    public static void Ejecutar(string rutaArchivo)
    {
        try
        {
            Process.Start(new ProcessStartInfo 
            {
                FileName = rutaArchivo,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al intentar abrir el archivo:\n{ex.Message}", "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}