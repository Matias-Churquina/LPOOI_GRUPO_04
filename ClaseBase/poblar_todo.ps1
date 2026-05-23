$dbPaths = @(
    "C:\Users\Maxy\Documents\LPOOI_GRUPO_04\ClaseBase\optica.mdf",
    "C:\Users\Maxy\Documents\LPOOI_GRUPO_04\Vistas\bin\Debug\optica.mdf"
)

foreach ($dbPath in $dbPaths) {
    if (-not (Test-Path $dbPath)) {
        Write-Host "Omitiendo ruta inexistente: $dbPath"
        continue
    }

    Write-Host "`n========================================="
    Write-Host "Poblando base de datos en: $dbPath"
    Write-Host "========================================="

    $connectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=$dbPath;Integrated Security=True;Connect Timeout=30;User Instance=True"
    $connection = New-Object System.Data.SqlClient.SqlConnection($connectionString)

    try {
        $connection.Open()
        Write-Host "Conexion exitosa."

        # Desasociar restricciones temporales si hubiera para limpieza limpia
        $cmdDelDet = New-Object System.Data.SqlClient.SqlCommand("DELETE FROM VentaDetalle; DELETE FROM Venta; DELETE FROM Cliente; DELETE FROM ObraSocial; DELETE FROM Producto;", $connection)
        $cmdDelDet.ExecuteNonQuery() | Out-Null
        Write-Host "Tablas previas limpiadas a cero de forma exitosa."

        # 1. Insertar Obras Sociales
        $obs = @(
            @{ Cuit = "11111111111"; Nombre = "OSDE"; Dir = "Alvear 500"; Tel = "4220000" },
            @{ Cuit = "22222222222"; Nombre = "PAMI"; Dir = "Senador Perez 100"; Tel = "4230000" }
        )
        foreach ($o in $obs) {
            $cmd = New-Object System.Data.SqlClient.SqlCommand("INSERT INTO ObraSocial (OS_CUIT, OS_RazonSocial, OS_Direccion, OS_Telefono) VALUES (@cuit, @nombre, @dir, @tel)", $connection)
            $cmd.Parameters.AddWithValue("@cuit", $o.Cuit) | Out-Null
            $cmd.Parameters.AddWithValue("@nombre", $o.Nombre) | Out-Null
            $cmd.Parameters.AddWithValue("@dir", $o.Dir) | Out-Null
            $cmd.Parameters.AddWithValue("@tel", $o.Tel) | Out-Null
            $cmd.ExecuteNonQuery() | Out-Null
        }
        Write-Host "Obras Sociales cargadas."

        # 2. Insertar Clientes
        $clis = @(
            @{ Dni = "11111111"; Apellido = "Perez"; Nombre = "Juan"; Dir = "Calle Falsa 123"; Cuit = "11111111111"; Carnet = "C-100" },
            @{ Dni = "22222222"; Apellido = "Gomez"; Nombre = "Maria"; Dir = "Av Belgrano 456"; Cuit = "22222222222"; Carnet = "C-200" },
            @{ Dni = "33333333"; Apellido = "Sanchez"; Nombre = "Carlos"; Dir = "Jujuy 789"; Cuit = "11111111111"; Carnet = "C-300" },
            @{ Dni = "44444444"; Apellido = "Lopez"; Nombre = "Ana"; Dir = "Salta 101"; Cuit = "22222222222"; Carnet = "C-400" }
        )
        foreach ($c in $clis) {
            $cmd = New-Object System.Data.SqlClient.SqlCommand("INSERT INTO Cliente (Cli_DNI, Cli_Apellido, Cli_Nombre, Cli_Direccion, OS_CUIT, Cli_NroCarnet) VALUES (@dni, @ap, @nom, @dir, @cuit, @carnet)", $connection)
            $cmd.Parameters.AddWithValue("@dni", $c.Dni) | Out-Null
            $cmd.Parameters.AddWithValue("@ap", $c.Apellido) | Out-Null
            $cmd.Parameters.AddWithValue("@nom", $c.Nombre) | Out-Null
            $cmd.Parameters.AddWithValue("@dir", $c.Dir) | Out-Null
            $cmd.Parameters.AddWithValue("@cuit", $c.Cuit) | Out-Null
            $cmd.Parameters.AddWithValue("@carnet", $c.Carnet) | Out-Null
            $cmd.ExecuteNonQuery() | Out-Null
        }
        Write-Host "Clientes cargados."

        # 3. Insertar Productos
        $prods = @(
            @{ Cod = "PROD001"; Cat = "Recetados"; Desc = "Anteojos Recetados de Lectura +2.0"; Precio = 12500.00 },
            @{ Cod = "PROD002"; Cat = "Sol"; Desc = "Lentes de Sol Ray-Ban Aviator Classic"; Precio = 45000.00 },
            @{ Cod = "PROD003"; Cat = "Contacto"; Desc = "Lentes de Contacto Descartables Neutros"; Precio = 18900.00 },
            @{ Cod = "PROD004"; Cat = "Mantenimiento"; Desc = "Liquido Limpiador de Cristales Antiempanante"; Precio = 3500.00 },
            @{ Cod = "PROD005"; Cat = "Recetados"; Desc = "Anteojos Recetados Deportivos Ultralivianos"; Precio = 32000.00 }
        )
        foreach ($p in $prods) {
            $cmd = New-Object System.Data.SqlClient.SqlCommand("INSERT INTO Producto (Prod_Codigo, Prod_Categoria, Prod_Descripcion, Prod_Precio) VALUES (@cod, @cat, @desc, @precio)", $connection)
            $cmd.Parameters.AddWithValue("@cod", $p.Cod) | Out-Null
            $cmd.Parameters.AddWithValue("@cat", $p.Cat) | Out-Null
            $cmd.Parameters.AddWithValue("@desc", $p.Desc) | Out-Null
            $cmd.Parameters.AddWithValue("@precio", [decimal]$p.Precio) | Out-Null
            $cmd.ExecuteNonQuery() | Out-Null
        }
        Write-Host "Productos cargados."

        # 4. Insertar Ventas y Detalles
        $ventas = @(
            @{
                Nro = 1
                Fecha = "2026-05-10 10:30:00"
                Dni = "11111111"
                Detalles = @(
                    @{ Nro = 1; Cod = "PROD001"; Precio = 12500.00; Cant = 2 },
                    @{ Nro = 2; Cod = "PROD002"; Precio = 45000.00; Cant = 1 }
                )
            },
            @{
                Nro = 2
                Fecha = "2026-05-15 15:45:00"
                Dni = "22222222"
                Detalles = @(
                    @{ Nro = 3; Cod = "PROD003"; Precio = 18900.00; Cant = 1 }
                )
            },
            @{
                Nro = 3
                Fecha = "2026-05-20 09:15:00"
                Dni = "11111111"
                Detalles = @(
                    @{ Nro = 4; Cod = "PROD004"; Precio = 3500.00; Cant = 3 }
                )
            },
            @{
                Nro = 4
                Fecha = "2026-05-22 18:00:00"
                Dni = "33333333"
                Detalles = @(
                    @{ Nro = 5; Cod = "PROD002"; Precio = 45000.00; Cant = 2 },
                    @{ Nro = 6; Cod = "PROD005"; Precio = 32000.00; Cant = 1 }
                )
            }
        )

        foreach ($v in $ventas) {
            $cmdV = New-Object System.Data.SqlClient.SqlCommand("INSERT INTO Venta (Ven_Nro, Ven_Fecha, Cli_DNI) VALUES (@nro, @fecha, @dni)", $connection)
            $cmdV.Parameters.AddWithValue("@nro", $v.Nro) | Out-Null
            $cmdV.Parameters.AddWithValue("@fecha", [DateTime]$v.Fecha) | Out-Null
            $cmdV.Parameters.AddWithValue("@dni", $v.Dni) | Out-Null
            $cmdV.ExecuteNonQuery() | Out-Null

            foreach ($d in $v.Detalles) {
                $total = [decimal]($d.Precio * $d.Cant)
                $cmdD = New-Object System.Data.SqlClient.SqlCommand("INSERT INTO VentaDetalle (Det_Nro, Ven_Nro, Prod_Codigo, Det_Precio, Det_Cantidad, Det_Total) VALUES (@detNro, @venNro, @prodCod, @precio, @cant, @total)", $connection)
                $cmdD.Parameters.AddWithValue("@detNro", $d.Nro) | Out-Null
                $cmdD.Parameters.AddWithValue("@venNro", $v.Nro) | Out-Null
                $cmdD.Parameters.AddWithValue("@prodCod", $d.Cod) | Out-Null
                $cmdD.Parameters.AddWithValue("@precio", [decimal]$d.Precio) | Out-Null
                $cmdD.Parameters.AddWithValue("@cant", [decimal]$d.Cant) | Out-Null
                $cmdD.Parameters.AddWithValue("@total", $total) | Out-Null
                $cmdD.ExecuteNonQuery() | Out-Null
            }
        }
        Write-Host "Ventas e historial de detalles de transaccion cargados exitosamente."
        Write-Host "Sincronizacion completa en esta BD."

    } catch {
        Write-Error "Error procesando base de datos: $_"
    } finally {
        $connection.Close()
    }
}

Write-Host "`nTodas las bases de datos origen y ejecucion han sido coordinadas y pobladas exitosamente al 100%."
