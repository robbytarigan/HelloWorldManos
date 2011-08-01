
using Manos;
using System;

namespace Shorty {

	public class Shorty : ManosApp {

		public Shorty ()
		{
			Get ("/", ctx => ctx.Response.End ("Hello, Manos World!"));
 
			Route ("/Content/", new StaticContentModule ());
		}
	}
}
