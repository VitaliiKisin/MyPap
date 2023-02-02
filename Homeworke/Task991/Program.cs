using namespace std;
 
int main()
{
    const int n=20;
    double a[n], sum, max=0.0, eps=1e-9;
    
    cout << "Enter " << n << " elements:\n";
    for (int i = 0; i < n; i++)
    cin >> a[i];    
    
    for (int i = 0; i < n/2; i++)
    {
    sum=a[i]*a[n-1-i];    
    if (i==0 || sum>max+eps) max=sum;
    }
 
    cout << "max=" << max << "\n";
    
system("pause");
return 0;
}