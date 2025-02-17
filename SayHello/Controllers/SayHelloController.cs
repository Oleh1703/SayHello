using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers
{
	public class SayHelloController : ControllerBase
	{
		public void SayHello()
		{
            Console.WriteLine("Say hello");
            //new commits:
            Console.WriteLine("Hello");
		}
	}
}
