using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {     
        public IActionResult Index()
        {
            Features features = new()
            {
                Id = 1,
                Title = "Award Winning",
                Description= "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam",
                Icon= "icon-1.png"
            };

            Features features1 = new()
            {
                Id = 2,
                Title = "Professional Staff",
                Description = "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam",
                Icon = "icon-2.png"
            };


            Features features2 = new()
            {
                Id = 3,
                Title = "Fair Prices",
                Description = "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam",
                Icon = "icon-3.png"
            };


            Features features3 = new()
            {
                Id = 4,
                Title = "24/7 Support",
                Description = "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam",
                Icon = "icon-4.png"
            };

            List<Features> featuresList = new List<Features> { features,features1,features2,features3 };


            Services services = new()
            {
                Id= 1,
                Title= "Digital Marketing",
                Description= "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet",
                Icon= "icon-5.png"
            };


            Services services1 = new()
            {
                Id = 2,
                Title = "Internet Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet",
                Icon = "icon-6.png"
            };


            Services services2 = new()
            {
                Id = 3,
                Title = "Content Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet",
                Icon = "icon-7.png"
            };


            Services services3 = new()
            {
                Id = 4,
                Title = "Social Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet",
                Icon = "icon-8.png"
            };


            Services services4 = new()
            {
                Id = 5,
                Title = "B2B Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet",
                Icon = "icon-9.png"
            };


            Services services5 = new()
            {
                Id = 6,
                Title = "Email Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet",
                Icon = "icon-10.png"
            };


            List<Services> serviceList=new List<Services> { services,services1,services2,services3,services4,services5 };


            Projects projects = new()
            {
                Id=1,
                Title= "Social Marketing Strategy",
                Description= "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem",
                Image= "project-4.jpg"
            };

            Projects projects1 = new()
            {
                Id = 2,
                Title = "Data Analytics & Insights",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem",
                Image = "project-1.jpg"
            };

            Projects projects2 = new()
            {
                Id = 3,
                Title = "Marketing Content Strategy",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem",
                Image = "project-2.jpg"
            };

            Projects projects3 = new()
            {
                Id = 4,
                Title = "Business Target Market",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem",
                Image = "project-3.jpg"
            };


            List<Projects> projectList = new List<Projects> { projects, projects1,projects2,projects3 };


            Experts experts = new()
            {
                Id=1,
                FullName= "Alex Robin",
                Position= "Founder & CEO",
                Image= "team-1.jpg"

            };


            Experts experts1 = new()
            {
                Id = 2,
                FullName = "Adam Crew",
                Position = "Co Founder",
                Image = "team-2.jpg"

            };


            Experts experts2 = new()
            {
                Id = 3,
                FullName = "Boris Johnson",
                Position = "Executive Manager",
                Image = "team-3.jpg"

            };


            Experts experts3 = new()
            {
                Id = 4,
                FullName = "Robert Jordan",
                Position = "Digital Marketer",
                Image = "team-4.jpg"

            };


            List<Experts> epxertList = new List<Experts> { experts,experts1,experts2,experts3 };


            Testimonial testimonial = new()
            {
                Id=1,
                Name="Client Name",
                Position="Profession",
                Description= "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo",
                Image= "testimonial-1.jpg"

            };

            Testimonial testimonial1 = new()
            {
                Id = 2,
                Name = "Client Name",
                Position = "Profession",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo",
                Image = "testimonial-2.jpg"

            };

            Testimonial testimonial2 = new()
            {
                Id = 3,
                Name = "Client Name",
                Position = "Profession",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo",
                Image = "testimonial-3.jpg"

            };

            Testimonial testimonial3 = new()
            {
                Id = 4,
                Name = "Client Name",
                Position = "Profession",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo",
                Image = "testimonial-4.jpg"

            };


            List<Testimonial> testimonialList = new List<Testimonial> { testimonial,testimonial1,testimonial2,testimonial3 };

            HomeVM model = new()
            {
                Features=featuresList,
                Services=serviceList,
                Projects=projectList,
                Experts= epxertList,
                Testimonial=testimonialList,

            };


            return View(model);
        }

      
    }
}