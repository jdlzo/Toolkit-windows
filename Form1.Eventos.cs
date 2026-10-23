using System;

namespace Mantenimiento;

public partial class Form1
{
    static void butonfuncion(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\admintareas.bat");
    static void Basuratemp(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\baasura-temp.bat");
    static void Efectovisual(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\efectosvisuales.bat");
    static void Limpidisk(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\liberarespaciodisk.bat");
    static void Informacionsyswin(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\infosystem.bat");
    static void Borrartotal(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\RevoUninstaller_Portable\RevoUninstaller_Portable\RevoUPort.exe");
    static void HabilitarServiciosWin(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\Deshabilita Servicios de Windows\Recuperar\1- Ejecuta todo Aqui.exe");
    static void DesabilitarWindUpdate (object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\Deshabilita Servicios de Windows\Desactivar Atualizaciones de WIN\Wub.exe");
    static void microsoftvisualc(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\Microsoft Visual C++\install_all.bat");
    static void HWinfo(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\hwi_848\HWiNFO64.exe");
    static void CrystalDiskinfo(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\CrystalDiskInfo\DiskInfo64A.exe");
    static void CrystalDiskmark(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\CrystalMark 3D25\CrystalMark3D25X64.exe");
    static void CPUZ(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\CPU-Z\cpu-z_2.20.2-en\cpuz_x64.exe");
    static void Drivers(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\SDI_R539\SDI_x64_R539.exe");
    static void DesabilitarServicios(object? sender, EventArgs r) => Lanzador.Ejecutar(@".\Herrami\Deshabilita Servicios de Windows\Desactivar\1- Ejecuta todo Aqui.exe");
    static void Kapersky(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\kapersky\KVRT.exe");
    static void Malware(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\adward\adwcleaner.exe");
    static void GraficoElim(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\[Guru3D]-DDU\DDU v18.1.5.4.exe");
    static void Contras(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\nirsoft_package_enc_1.30.24\NirLauncher.exe");
    static void RecuperarArchivos(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\testdisk-7.3-WIP.win64\testdisk-7.3-WIP\qphotorec_win.exe");
    static void Respaldo(object? sender, EventArgs e) => Lanzador.Ejecutar(@".\Herrami\fastcopy\FastCopy5.11.3_x64\FastCopy.exe");
}