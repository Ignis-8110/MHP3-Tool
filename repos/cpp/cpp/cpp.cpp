// cpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

bool CheckNum(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    return false;
}

void RemoveTail(std::string& str)
{
    str.erase(str.size() - 2, 2);
}

class richard
{
public:
    int a;
    int b;
};

int main()
{
    char a;
    int b;
    unsigned int c;
    richard d;

    std::cout << sizeof(int) << " " << sizeof(char) << " " <<sizeof(c) << " " << sizeof(d);
    //int a;
    //std::string even;
    //std::string odd;
    //int i = 5;
    //while (i--)
    //{
    //    std::cin >> a;
    //    if (CheckNum(a))
    //    {
    //        even.append(std::to_string(a));
    //        even.append(", ");
    //    }
    //    else if(!CheckNum(a))
    //    {
    //        odd.append(std::to_string(a));
    //        odd.append(", ");
    //    }
    //}
    //RemoveTail(odd);
    //RemoveTail(even);
    //std::cout << "ODD : " << odd << "\n";
    //std::cout << "EVEN : " << even;
}

