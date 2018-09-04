#include<iostream>
#include<cstring>
#include"sort.cpp"
#pragma warning(disable: 4996)

template<class T>
std::ostream& operator << (std::ostream& os, const Container<T>& num)
{
	os << num.getId();
	return os;
}

template <typename T >
class Container
{
	T * arr;
	int count = 1;
	static int counter;
	int id;
public:
	Container(T num )
	{
		arr = new T(num);
		id = counter++;
	}
	~Container()
	{
		for (int i = 0; i < count; i++)
			delete arr[i];
	}
	template<typename TCallback>
	void push(T num , TCallback callback)
	{
		T * tmp = new T [++count];
		for (int i = 0; i < count-1; i++)
			tmp[i] = arr[i];
		tmp[count - 1] = num;
		delete[] arr;
		arr = tmp;
		sort(callback);
	}
	int size()
	{
		return count * sizeof(T);
	}
	T &operator[] (int index)
	{
		return arr[index];
	}
	template<typename TCallback>
	void sort( TCallback callback )
	{
		for (int i = 0; i < count; i++)
			for (int j = 0; j < count; j++)
				if (callback(arr[i], arr[j]))
					std::swap(arr[i], arr[j]);
	}
	void print()
	{
		for (int i = 0; i < count; i++)
			std::cout << arr[i] << "\n";
	}
	int getId()
	{
		return id;
	}
	bool operator < (const Container& num) const
	{
		return id < num.id;
	}
	bool operator > (const Container& num) const
	{
		return id > num.id;
	}
};

template<typename T>
int Container<T>::counter = 0;
