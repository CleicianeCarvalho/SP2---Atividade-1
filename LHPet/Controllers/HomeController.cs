using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Maria A. Ferreia", "857.546.320-89", "mariaf@hotmail.com", "Madruga");
        Cliente cliente2 = new Cliente(02, "Willian Henry Gates", "039.618.250.-09", "bill@gmail.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada lovelace", "904.777.720-98", "ada@hotmail.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus torvalds", "765.432.456-09", "linust@gmail.com", "Piguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.567.656-76", "gracehopper@hotmail.com", "Lobo");

        //lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
       
        

        ViewBag.listaClientes = listaClientes;
        


        //Instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl ALT Dog", "15.821.201/0001-78", "ctrl@alt.dog");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "34.210.341/0001-90", "boots.pet@gatomania.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok dog", "67.234.201/0001-34", "noisnamidia@tiktok.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "45.231.345/0001-32", "contato@bff.us");

        //lista de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        //lista de fornecedores
         

        ViewBag.listaFornecedores = listaFornecedores;


        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
