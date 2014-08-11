/*
Filename: SelectionSort.cs
Author: Rick Fogle
Creation Date: 04 July 2014

Purpose:
Source code for the SelectionSort.exe command-line executable. I created this to help me learn two
things:
1. How to implement a Selection sort.
2. Coding in C#.

External Resources: 
System namespace, 

NOTES: 

*/

// Declare external namespaces used.
using System;

// Load any external DLL's or files used.

class CL_SelectionSort{

	/*################################################################################
	// Main Method Definition.
	Inputs: None
	Outputs: None
	Modifies: None
	Returns: retcode (0/pass,1/fail)
	################################################################################*/
	static int Main(){
		// Set up the array of data to be sorted.
//		int [] iNumbers = new int [20] {20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1}; //Worst Case, totally inverted.
//		int [] iNumbers = new int [20] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}; //Best Case, already sorted.
		int [] iNumbers = new int [20] {1, 2, 3, 4, 5, 6, 10, 7, 8, 9, 20, 17, 19, 11. 12, 18, 16, 14,13,15}; //Testing, varies.
		int retcode = 0; // Initialize the return value to 0 (pass).
	
		//Write out the intial array
		retcode = PrintArray(iNumbers);

		//Sort the array.
		retcode = SortArray(iNumbers);

		//Write out the sorted array
		retcode = PrintArray(iNumbers);

	return(retcode); 
	} // End of Main() function.


	// Method Definitions.
	/*########################################
	SortArray()
	Sort the passed-in array numerically in low to high order.  This version implements a Selection Sort.

	Inputs: integer array of numbers.
	Outputs: None
	Modfies: The passed in array.
	Returns: retcode (0/pass,1/fail)

	NOTES: 
	Duplicate values are not swapped when detected since there's really no point in it.
	Maybe use a do-while loop instead of a for loop just for fun?
	########################################*/
	static int SortArray(int[ ] iNumbers){
		
		// Set up method variables.
		int iTemp;
		int iPassCount, iCompCount;
		bool bSwap = true;
		int retcode = 0;
		
		// Sort the array.
		for (int x = 0; x < n; x++){
			 int index _of_min = x;
			
			for(int y = x; y < n; y++){
				if(iNumbers[index_of_min] > iNumbers[y])
					{
						index_of_min = y;
					}
				int temp = iNumbers[x];
				iNumbers[x] = iNumbers[index_of_min];
				iNumbers[index_of_min] = temp;
			} //end of inner loop.
		}  //end of outer loop.
		return(retcode);
	}

	/*########################################
	PrintArray()
	Sends the passed-in array elements to the console window..

	Inputs: integer array of numbers.
	Outputs: described above.
	Modifies: None
	Returns: retcode (0/pass,1/fail)

	NOTES:
	########################################*/
	static int PrintArray(int[ ] iNumbers){
		int iTemp;
		int retcode = 0;
		for (iTemp = 0; iTemp <= iNumbers.Length - 1; iTemp++){
			if(iTemp == iNumbers.Length - 1){
				Console.Write("{0} \n", iNumbers[iTemp]);
			}
			else{
				Console.Write("{0}, ", iNumbers[iTemp]);
			}
		}
		return(retcode);
	}

} // End of CL_ModBubbleSort class definition.

