#include <iostream>
#include <vector>
#include <queue>
using namespace std;

int main()
{
    int a;
    cin >> a;
    vector<int> numsIn;
    int b;
    for (int i = 0; i < a; i++)
    {
        cin >> b;
        numsIn.push_back(b);
    }
    int current, max, ans;
    cin >> current >> max;
    queue<int> q;
    q.push(current);
    int i = 0;//index into array
    ans = -1;
    while (q.size() != 0 && i < numsIn.size()) {
        int qsize = q.size();
        for (int j = 0; j < q.size(); j++) {
            int currVal = q.front();
            q.pop();
            int addValue = currVal + numsIn[i];
            int subValue = currVal - numsIn[i];
            if (subValue >= 0 && subValue <= max)
                q.push(subValue);
            if (addValue >= 0 && addValue <= max)
                q.push(addValue);
        }
        i++;
        while (q.size() != 0) {
            ans = std::max(ans, q.front());
            q.pop();
            return ans == current ? -1 : ans;
        }
    }
    cout << ans;
}