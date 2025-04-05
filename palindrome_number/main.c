#include <stdbool.h>
#include <stdio.h>

bool isPalindrome(int x);

int main() {
  bool result = isPalindrome(101);

  printf("%d", result);
  return result;
}

bool isPalindrome(int x) {
  int len = 0;
  int number = x;

  if (x < 0) {
    return false;
  }

  while (x >= 1) {
    x = x / 10;
    len++;
  }

  if (len == 1) {
    return true;
  }

  char str_num[len + 2];
  int initial_index = 0;
  int final_index = len - 1;

  sprintf(str_num, "%d", number);

  while (initial_index != final_index && initial_index < final_index) {
    if (str_num[initial_index] != str_num[final_index]) {
      return false;
    }
    initial_index++;
    final_index--;
  }

  return true;
}