﻿/* Questio_1:  Create a class called Accounts which has data members/fields like Account no, 
 Customer name, Account type, Transaction type (d/w), amount, balance
D->Deposit
W->Withdrawal

-write a function that updates the balance depending upon the transaction type

	-If transaction type is deposit call the function credit by passing the amount to 
be deposited and update the balance

  Credit(int amount) function 

	-If transaction type is withdraw call call the function debit by passing the 
amount to be withdrawn and update the balance

  Debit(int amt) function 

-Pass the other information like Acount no, customer name,acc type through constructor

-call the show data method to display the values.
-----------------------------------------------------------------------------------------------
Question 2: Create a class called student which has data members like rollno, name,
class, Semester, branch, int [] marks=new int marks [5](marks of 5 subjects )

-Pass the details of student like rollno, name, class, SEM, branch in constructor

-For marks write a method called GetMarks() and give marks for all 5 subjects

-Write a method called displayresult, which should calculate the average marks

-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35,but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.

-Write a DisplayData() method to display all values.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
