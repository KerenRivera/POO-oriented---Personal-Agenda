using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_project
{
     class Agenda
     {
        private Dictionary<int, Contacto> contactos = new Dictionary<int, Contacto>();

        public void AddContact()
        {
            Console.WriteLine("Vamos a agregar el contacto.");

            int id = contactos.Count + 1;
            Console.Write("Digite el Nombre: ");
            string name = Console.ReadLine();
            
            Console.Write("Digite el Teléfono: ");
            string phone = Console.ReadLine();

            Console.Write("Digite el Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Digite la dirección: ");
            string address = Console.ReadLine();

            contactos.Add(id, new Contacto(id, name, phone, email, address));
            Console.WriteLine("Contacto agregado.\n");
        }

        public void ViewContact()
        {

            Console.WriteLine("Id           Nombre          Telefono            Email           Dirección");
            Console.WriteLine("___________________________________________________________________________");

            foreach (var contacto in contactos.Values)
            {
                Console.WriteLine($"{contacto.Id}    {contacto.Name}      {contacto.Phone}      {contacto.Email}     {contacto.Address}");
            }
        }

        public void SearchContact()
        {
            Console.WriteLine("Digite un Id de Contacto para Mostrar: ");
            int idSeleccionado;
            if (int.TryParse(Console.ReadLine(), out idSeleccionado) && contactos.ContainsKey(idSeleccionado))
            {
                var cont = contactos[idSeleccionado];
                Console.WriteLine($"{cont.Id}   {cont.Name}   {cont.Phone}   {cont.Email}   {cont.Address}");
            }
            else
            {
                Console.WriteLine("El contacto no existe.");
            }
        }

        public void EditContact()
        {
            ViewContact();
            Console.WriteLine("Digite un  Id de Contacto para Editar: ");
            int idSeleccionado;

            if(int.TryParse(Console.ReadLine(),out idSeleccionado) && contactos.ContainsKey(idSeleccionado))
            {
                var c = contactos[idSeleccionado];

                Console.WriteLine($"Nuevo Nombre: {c.Name}");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName)) c.Name = newName;

                Console.WriteLine($"Nuevo Teléfono: {c.Phone}");
                string newPhone = Console.ReadLine();
                if (!string.IsNullOrEmpty(newPhone)) c.Phone = newPhone;

                Console.WriteLine($"Nuevo Email: {c.Email}");
                string newEmail = Console.ReadLine();
                if (!string.IsNullOrEmpty(newEmail)) c.Email = newEmail;

                Console.WriteLine($"Nueva Dirección: {c.Address}");
                string newAddress = Console.ReadLine();
                if (!string.IsNullOrEmpty(newAddress)) c.Address = newAddress;

                Console.WriteLine("Contacto actualizado.");
            }
            else
            {
                Console.WriteLine("El contacto no existe.");
            }
        }

        public void DeleteContact()
        {
            ViewContact();
            Console.WriteLine("Digite un Id de Contacto para Eliminar: ");
            int idSeleccionado;
            if (int.TryParse(Console.ReadLine(), out idSeleccionado) && contactos.ContainsKey(idSeleccionado))
            {
                Console.WriteLine("Seguro que desea eliminar? 1. Sí, 2. No");
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    contactos.Remove(idSeleccionado);
                    Console.WriteLine("Contacto eliminado.");
                }
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
     }

    
}
