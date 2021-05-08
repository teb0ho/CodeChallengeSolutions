// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A) {
    // write your code in JavaScript (Node.js 8.9.4)
      const arrayNums = [...A];

    let min = 1;

    while (arrayNums.includes(min)) {
        min++;
    }

    return min;
}
