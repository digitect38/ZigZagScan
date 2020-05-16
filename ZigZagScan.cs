using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ZigZagScan
{
	readonly int _a, _b;

	List<(int, int)> path = new List<(int, int)>();

	public ZigZagScan(int a, int b = 0)
	{
		_a = a;
		_b = b == 0 ? b = _a : b;
	}

	public List<(int, int)> BuildPath()
	{
		int i = 0, j = 0, d = 1;

		path.Clear();
		path.Add((0, 0));

		while (i < _a || j < _b)
		{
			Next(ref i, ref j, ref d);
			path.Add((i, j));
		}

		path.Add((_a, _b));

		return path;
	}

	void Next(ref int i, ref int j, ref int d)
	{
		if (d == 1)
		{
			if (i == _a)
			{
				j++; d = -1;
			}
			else if (j == 0)
			{
				i++; d = -1;
			}
			else
			{
				i++; j--;
			}
		}
		else
		{
			if (j == _b)
			{
				i++; d = +1;
			}
			else if (i == 0)
			{
				j++; d = +1;
			}
			else
			{
				j++; i--;
			}
		}
	}
}
