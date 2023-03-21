#include <iostream>
using namespace std;

int main() {
    //Input Array
    int n;
    cin >> n;
    int arr[10000];
    for (int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    int currentSum = 0;
    int maxSum = INT_MIN;
    //algo
    for (int i = 0; i < n; i++)
    {
        currentSum += arr[i];
        if (currentSum < 0)
        {
            currentSum = 0;
        }
        maxSum = max(maxSum, currentSum);
    }
    cout << maxSum << endl;

    return 0;
}