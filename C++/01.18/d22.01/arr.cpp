class Arr
{
	int * buf;
	int index;
	size_t  size;
public:
	Arr() = default;
	Arr(size_t aSize)
	{
		buf = new int[aSize];
		size = aSize;
	}
	Arr(Arr&& aArr)
	{
		size = aArr.size;
		index = aArr.index;
		buf = new int[size];
		for (int i = 0; i < size; i++)
		{

		}
	}
	~Arr()
	{
		delete[] buf;
	}
	Arr(const Arr &) = delete;
	Arr &operator= (const Arr &) = delete;
	void push(int num)
	{
		if (index >= size)
		{
			size *= 2;
			int *tmp = new int[size];
			for (int i = 0; i < index; i++)
			{
				tmp[i] = buf[i];
			}
			delete[] buf;
			buf = tmp;
			buf[index++] = num;
		}
		else
		{
			buf[index++] = num;
		}
	}
	void remove(int aIndex)
	{
		for (int i = aIndex; i < index; i++)
		{
			buf[i] = buf[i + 1];
		}
	}
	int & operator[](int n)
	{
		return buf[n];
	}

};