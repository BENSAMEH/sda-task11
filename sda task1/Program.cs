using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_task1
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}
    //single responsibility
    public class Report
    {
   
        public void GenerateReport()
        {
            
            
        }
    }

  
    public class ReportSaver
    {
        public void SaveToFile()
        {
            

           
        }
    }
    //ocp
 
    public interface IShape
    {
        double CalculateArea();
    }

    // Circle implementation
    public class Circle : IShape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    
    public class Rectangle : IShape
    {
        public double Width ;
        public double Height  ; 

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }//LSP
    public abstract class Bird
    { 
       
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("sparrow fly");
        }
    }

    public class Ostrich : Bird
    {
        
    }
    //ISP
    public interface IWalkable
    {
        void Walk();
    }

    public interface IFlyable2
    {
        void Fly();
    }

    public class Dog : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Dog Walking");
        }
    }

    public class Bird2 : IWalkable, IFlyable2
    {
        public void Walk()
        {
            Console.WriteLine("Bird Walking");
        }

        public void Fly()
        {
            Console.WriteLine("Bird Flying");
        }
    }//DIP
 
    public interface IEmailService
    {
        void SendEmail(string message);
    }

   
    public class EmailService : IEmailService
    {
        public void SendEmail(string message)
        {
            
        }
    }

    
    public class UserController
    {
        private readonly IEmailService _emailService;

        
        public UserController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void RegisterUser(string username)
        {
            _emailService.SendEmail("Welcome " + username);
        }
    }

    
 




}
