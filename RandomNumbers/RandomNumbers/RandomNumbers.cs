//   RandomNumbers.cs
//  
//  Author:
//       Zeno Gantner <zeno.gantner@gmail.com>
// 
//  Copyright (c) 2012 Zeno Gantner
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Diagnostics;

public static class RandomNumbers
{
	const int N = 1000000;
	
	public static void Main(String[] args)
	{
		measureNext(new Random(), "System.Random", 100);
	}
	
	static void measureNext(Random rng, String name, int n)
	{
		long end = N * n;

		Stopwatch stop_watch = new Stopwatch();
		stop_watch.Start();
		for (long i = 0; i < end; i++)
			rng.Next();
		stop_watch.Stop();
		Console.WriteLine("{0}.Next() ({1}) {2:0} ms\n", name, n, stop_watch.Elapsed.TotalMilliseconds);
	}
}
