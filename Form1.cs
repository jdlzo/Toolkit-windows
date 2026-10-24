using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace Mantenimiento;

public partial class Form1 : Form
{
    private Label texto;


    public Form1()
    {
        InitializeComponent();
        ConfigurarInterfaz();
        VerificarActualizaciones();
    }
    private void VerificarActualizaciones()
        {
            // Opcional: Si no especificas el changelog en el XML, puedes ocultarlo
            // AutoUpdater.ShowSkipButton = false;

            // Apunta a la URL de tu archivo XML remoto
            AutoUpdater.Start("https://raw.githubusercontent.com/jdlzo/Toolkit-windows/refs/heads/main/update.xml");
        }

    private void ConfigurarInterfaz()
    {
        this.MinimumSize = this.Size;
        this.MaximumSize = this.Size;   
        this.MinimizeBox = false;
        this.MaximizeBox = false;
        this.BackColor = Color.FromArgb(244, 240, 234);

        texto = CrearLabel("Herramientas", 230, 10);
        texto.Font = new Font(texto.Font.FontFamily, 15, FontStyle.Bold);
        texto.Size = new Size(250, 30);
        this.Controls.Add(texto);



        Label ver = new Label();
        ver.Text="v1.0.0-beta";
        ver.Location = new Point(13,10);
        ver.ForeColor = Color.Gray; 
        ver.Font = new Font(ver.Font.FontFamily, 9, FontStyle.Italic);
        //ver.Size = new Size(50,20);
        ver.AutoSize = true;
        this.Controls.Add(ver);
        
        Button btnActualizar = new Button();
        btnActualizar.Text = "Comprobar actualizaciones";
        btnActualizar.Location = new Point(13, 40); // Ajusta la posición X e Y según necesites
        btnActualizar.Size = new Size(160, 30);
        btnActualizar.Cursor = Cursors.Hand;
        
        // Evento que se ejecuta al hacer clic en el botón
        btnActualizar.Click += (sender, e) =>
        {
            // Reemplaza esta URL con el enlace Raw de tu Gist o tu archivo XML en GitHub
            AutoUpdater.Start("https://raw.githubusercontent.com/jdlzo/Toolkit-windows/refs/heads/main/update.xml");
        };

        this.Controls.Add(btnActualizar);


        this.Controls.Add(CrearLabel("Sistema y Limpieza", 40, 70));
        this.Controls.Add(CrearLabel("Diagnóstico Hardware", 250, 70));
        this.Controls.Add(CrearLabel("Seguridad y Soporte", 460, 70));

        // botones de limpieza o los de en medio 
        this.Controls.Add(CrearBoton("Administrador de Tareas", 40, 110, butonfuncion));
        this.Controls.Add(CrearBoton("Eliminar basura", 40, 145, Basuratemp));
        this.Controls.Add(CrearBoton("Efectos de windows", 40, 180, Efectovisual));
        this.Controls.Add(CrearBoton("Limpiar discos", 40, 215, Limpidisk));
        this.Controls.Add(CrearBoton("Información sistema", 40, 250, Informacionsyswin));
        this.Controls.Add(CrearBoton("Borrar aplicaciones total", 40, 285, Borrartotal));
        this.Controls.Add(CrearBoton("Desabilitar servicios Windows",40,320,DesabilitarServicios));
        this.Controls.Add(CrearBoton("Habilitar servicios Windows",40,355,HabilitarServiciosWin));
        this.Controls.Add(CrearBoton("Desabilitar WindowsUpdate",40,390,DesabilitarWindUpdate));

        //Botones Hardware
        this.Controls.Add(CrearBoton("HWinfox64", 250, 110, HWinfo));
        this.Controls.Add(CrearBoton("Estado de discos", 250, 145, CrystalDiskinfo));
        this.Controls.Add(CrearBoton("Pruebas GPU", 250, 180, CrystalDiskmark));
        this.Controls.Add(CrearBoton("CPU-Z", 250, 215, CPUZ));
        this.Controls.Add(CrearBoton("Actualización de drivers", 250, 250, Drivers));
        
        


        //Botones Seguridad y soporte
        this.Controls.Add(CrearBoton("Antivirus Kaspersky", 460, 110, Kapersky));
        this.Controls.Add(CrearBoton("ADWMalwarebytes", 460, 145, Malware));
        this.Controls.Add(CrearBoton("Eliminar Drivers Grafica(Cuidado)", 460, 180, GraficoElim));
        this.Controls.Add(CrearBoton("Recuperar contraseñas navegador", 460, 215, Contras));
        this.Controls.Add(CrearBoton("Recuperar Archivos (PhotoRec)", 460, 250, RecuperarArchivos));
        this.Controls.Add(CrearBoton("Respaldo Discos", 460, 285, Respaldo));
        this.Controls.Add(CrearBoton("Microsoft Visual c++", 460, 320, microsoftvisualc));

        AplicarEstiloBotones();
    }

    private Label CrearLabel(string txt, int x, int y)
    {
        return new Label {
            Text = txt,
            Font = new Font(this.Font.FontFamily, 10, FontStyle.Bold),
            Size = new Size(200, 25),
            Location = new Point(x, y),
            TextAlign = ContentAlignment.MiddleCenter
        };
    }

    private Button CrearBoton(string txt, int x, int y, EventHandler evento)
    {
        Button btn = new Button {
            Text = txt,
            Size = new Size(200, 30),
            Location = new Point(x, y)
        };
        btn.Click += evento;
        return btn;
    }

    private void AplicarEstiloBotones()
    {
        foreach (Control c in this.Controls)
        {
            if (c is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(232, 223, 211);
                btn.ForeColor = Color.FromArgb(87, 80, 75); 
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 209, 196);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 193, 178);
            }
        }
    }
}