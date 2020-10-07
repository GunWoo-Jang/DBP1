using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading;

namespace 과제2_1 {
    interface IOperation {
        void Insert(string str);
        string Delete();
        bool Search(string str);
        string GetCurrentElt();
        int NumOfElements();
    }

    class Stack : IOperation {
        private int size; // 스택 사이즈
        private int top; // top 위치
        private string[] stack; // 내용이 들어갈 stack

        public Stack() {
            this.size = 3; // 초기 스택 사이즈 3
            this.top = -1; // 초기 스택 top위치 -1
            this.stack = new string[3]; // 초기 stack 생성
        }

        public void full() {
            if (top == (size - 1)) { // 스택이 꽉차면
                size++; // 사이즈를 늘려주고 알려준다
                Console.WriteLine($"Stack size error : ({size}로 늘립니다)");
                Array.Resize(ref stack, size); // 늘린 사이즈로 스택 resize
            }
        }

        public Boolean empty() {
            if (top == -1) { // 스택이 비었으면 경고문 출력
                Console.WriteLine("Stack size error : empty)");
                return true;
            }
            else
                return false;
        }

        public void element_seach() {
            for (int i = 0; i < size; i++) { // 스택의 모든 요소 출력
                Console.WriteLine($"stack[{i}] = {stack[i]}");
            }
        }

        public void Insert(string str) {
            full(); // 스택이 꽉차있는지 검사
            stack[++top] = str; // 요소를 넣고 top+1
        }

        public string Delete() {
            string str = GetCurrentElt(); // 맨 위 요소 꺼내고
            stack[top--] = null; // 꺼낸 위치에 null 값을 넣고 top-1
            Console.WriteLine("위 값을 반환 후 제거하였습니다");
            return str; // 꺼낸 요소 반환
        }

        public bool Search(string str) {
            if (stack.Contains(str)) { // 찾는 요소가 스택에 있다면
                Console.WriteLine($"『{str}』 찾았습니다");
                return true;
            }
            else { // 찾는 요소가 스택에 없다면
                Console.WriteLine($"『{str}』 찾지 못하였습니다");
                return false;
            }
        }

        public string GetCurrentElt() {
            if (!empty()) { // 스택이 비어있는지 검사
                Console.WriteLine($"『{stack[top]}』 반환하였습니다");
                return stack[top]; // top 위치 요소 반환
            }
            else
                return null; // 비어있다면 null return
        }

        public int NumOfElements() {
            Console.WriteLine($"큐의 요소 갯수는 {top + 1} 입니다.");
            return top + 1; // top + 1 = 원소 개수
        }

    }

    class Queue : IOperation {
        private int size;
        private int front;
        private int rear;
        private string[] queue;

        public Queue() {
            this.size = 3; // 초기 사이즈 3
            this.front = 0; // 초기 front위치 0
            this.rear = -1; // 초기 rear위치 -1
            this.queue = new string[3]; // 초기 queue 생성
        }

        public void full() {
            if (rear == size - 1) { // 큐가 꽉차면 알려주고
                size++;
                Console.WriteLine($"Queue size error : ({size}로 늘립니다)");
                Array.Resize(ref queue, size); // 큐 사이즈 resize
            }
        }

        public Boolean empty() {
            if (front == rear + 1) { // 큐가 비어있다면
                Console.WriteLine("Queue size error : empty)");
                return true; // 알려주고 true return 
            }
            else return false;
        }

        public void element_seach() {
            for (int i = 0; i < size; i++) { // 큐의 모든 요소 출력
                Console.WriteLine($"queue[{i}] = {queue[i]}");
            }
        }

        public void Insert(string str) {
            full(); // 꽉차있는지 검사
            queue[++rear] = str; // 요소를 넣고 rear+1
        }

        public string Delete() {
            string str = GetCurrentElt(); // 요소를 꺼내와서 str에
            queue[front++] = null; // front 위치에 null 넣고 +1
            Console.WriteLine("위 값을 반환 후 제거하였습니다");
            return str; // 꺼낸 요소 반환
        }

        public bool Search(string str) {
            if (queue.Contains(str)) { // 찾는 요소가 큐에 있다면
                Console.WriteLine($"『{str}』 찾았습니다");
                return true;
            }
            else { // 찾는 요소가 큐에 없다면
                Console.WriteLine($"『{str}』 찾지 못하였습니다");
                return false;
            }
        }

        public string GetCurrentElt() {
            empty(); // 비어있는지 검사
            Console.WriteLine($"『{queue[front]}』 반환하였습니다");
            return queue[front]; // front 위치 요소 반환
        }

        public int NumOfElements() {
            Console.WriteLine($"큐의 요소 갯수는 {rear - front + 1} 입니다. ");
            return rear - front + 1; // rear - front + 1 = 요소 개수
        }
    }
}
