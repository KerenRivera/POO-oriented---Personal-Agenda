using Contacts_project;

Console.WriteLine("Mi Agenda Perrón");

Console.WriteLine("Bienvenido a tu lista de contactos");

Agenda agenda = new Agenda();
bool running = true;


while (running)
{

    Console.WriteLine("1. Agregar Contacto   2. Ver Contacto   3. Buscar Contacto   4. Editar Contacto   5. Eliminar Contacto   6. Salir");
    Console.Write("Elija una opción: ");

    int choice;
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Opcion no válida");
        continue;
    }

    switch (choice)
    {
        case 1:
            agenda.AddContact();
            break;
        case 2:
            agenda.ViewContact();
            break;
        case 3:
            agenda.SearchContact();
            break;
        case 4:
            agenda.EditContact();
            break;
        case 5:
            agenda.DeleteContact();
            break;
        case 6:
            running = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
}

