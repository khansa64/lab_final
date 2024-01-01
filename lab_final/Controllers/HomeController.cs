using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Context = System.Runtime.Remoting.Contexts.Context;

namespace lab_final.Controllers
{
    public class PatientsController : Controller
    {
        private readly AppDbContext_context;
        {
            Context Context;
        }

       // Implement CRUD actions for patients
}

// DoctorsController.cs
public class DoctorsController : Controller
{
    private readonly DbContext _context;

    public DoctorsController(DbContext context)
    {
        _context = context;
    }

    // Implement CRUD actions for doctors
}

// AppointmentsController.cs
public class AppointmentsController : Controller
{
    private readonly DbContext _context;

    public AppointmentsController(DbContext context)
    {
        _context = context;
    }

// Implement CRUD actions for appointments
}