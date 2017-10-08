<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Código que se ejecuta al iniciarse la aplicación.
        // Cuando entra el primer usuario a la aplicación.
        Application["nUsuarios"] = 0;
    }

    void Application_End(object sender, EventArgs e)
    {
        // Código que se ejecuta durante el cierre de aplicaciones.
        // Cuando sale el último usuario de la aplicación.
        Application.Clear();
    }

    void Session_Start(object sender, EventArgs e)
    {
        // Código que se ejecuta cuando se inicia una nueva sesión
        // Cuando entra un nuevo usuario.
        Session["nVisitante"] = new Contar().Visitas();
        Session["hora"] = DateTime.Now.ToString("HH:mm");

        Application.Lock();
        Application["nUsuarios"] = Int16.Parse(Application["nUsuarios"].ToString()) + 1;
        Application.UnLock();
    }

    void Session_End(object sender, EventArgs e)
    {
        // Código que se ejecuta cuando finaliza una sesión. 
        // Cuando sale un usuario.
        Application.Lock();
        Application["nUsuarios"] = Int16.Parse(Application["nUsuarios"].ToString()) - 1;
        Application.UnLock();
    }

    void Application_BeginRequest(object sender, EventArgs e)
    {
        // Este manejador de evento, realiza verificaciones de rutas de acceso y ayuda a prevenir los caracteres no válidos y las direcciones URL mal formadas.
        // Código creado por Microsoft (violación de seguridad).

        if (Request.Path.IndexOf('\\') >= 0 || System.IO.Path.GetFullPath(Request.PhysicalPath) != Request.PhysicalPath)
        {
            throw new HttpException(404, "not found");
        }
    }
</script>
