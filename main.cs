using System;
using System.Collections;
using System.IO;
using System.Threading;


namespace 과제2_1 {
    class MainApp {
        static void Main(string[] args) {
            Stack stk = new Stack(); // 스택 생성

            stk.Insert("안"); // 하나씩 push
            stk.Insert("녕");
            stk.Insert("하");
            stk.Insert("세");
            stk.Insert("요");

            stk.Delete(); // pop한 후 반환
            stk.Search("안"); // 존재 여부 반환
            stk.Search("응");
            stk.GetCurrentElt(); // top 요소 반환
            stk.NumOfElements(); // 원소 개수 반환

            stk.element_seach(); // 모든 요소 출력

            Queue que = new Queue(); // 큐 생성

            que.Insert("반"); // 하나씩 rear에 삽입
            que.Insert("갑");
            que.Insert("습");
            que.Insert("니");
            que.Insert("다");

            que.Delete(); // front 요소 제거 후 반환
            que.Search("다"); // 존재 여부 반환
            que.Search("흐");
            que.GetCurrentElt(); // front 요소 반환
            que.NumOfElements(); // 원소 개수 반환

            que.element_seach(); // 모든 요소 출력

            Console.WriteLine("안녕히가세요");
        }
    }
}
