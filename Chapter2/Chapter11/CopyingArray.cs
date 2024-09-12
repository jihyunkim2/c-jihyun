//Chapter11 일반화 메소드 

namespace Chapter11
{
    class CopyingArray
    {
        static void CopyArray<T>(T[]source, T[] taget) 
        {
            for( int i = 0;i<source.Length; i++ ) //<T>는 메서드의 형식 매개변수 
                taget[i] = source[i]; // 배열 source 에서 배열 taget으로 데이터 복사 
           
        }
        
        static void Main111(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] taget= new int[source.Length];  //정수형 배열 선언 source taget

            CopyArray<int>(source, taget); //형식 매개변수 T에 int 대입해서 호출  1번째 int 형으로 사용

            foreach( int e in taget ) //foreach 루프를 사용해서 복사된 정수형 배열의 요소 출력
                Console.WriteLine(e);

            string[] source2 = { "하나", "둘", "셋" };
            string[] taget2 =new string[source2.Length];

            CopyArray<string>(source2 , taget2); // 형식 매개변수에 string 대입 2번째는 string 형으로 사용

            foreach(string e in taget2 ) 
                Console.WriteLine(e );

            

            
    }
}
