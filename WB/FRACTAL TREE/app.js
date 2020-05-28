const countDown = 30000;
let tree = [];
let leaves = [];

function setup() {
  createCanvas(400, 400);
  tree.push(
    new branchConstructor(
      createVector(width / 2, height),
      createVector(width / 2, height - 120)
    )
  );
  for (let i = 0; i < countDown; i++) {
    tree.push(tree[i].newBranch(PI / 6));
    tree.push(tree[i].newBranch(-PI / 6));
  }
  tree.forEach((branch) => {
    leaves.push(branch.end.copy());
  });
  leaves.shift();
}
function draw() {
  background(0);
  tree.forEach((branch) => {
    branch.show();
  });
//   leaves.forEach((leaf) => {
//     noStroke();
//     fill(255, 0, 100, 100);
//     ellipse(leaf.x, leaf.y, 8, 8);
//   });

//   for (let i = 0; i < leaves.length; i++) {
//         leaves[i].y += random(0, i*i/(i*500))    
//         leaves[i].x += random(-i/(i*1000), i/5000)    
//   }

}

class branchConstructor {
  constructor(start, end) {
    this.start = start;
    this.end = end;
    this.show = function () {
      stroke(255, 100, 100, 90);
      line(this.start.x, this.start.y, this.end.x, this.end.y);
    };
    this.newBranch = function (rotation) {
      const direction = p5.Vector.sub(this.end, this.start);
      direction.rotate(rotation);
      direction.mult(0.68);
      return new branchConstructor(
        this.end,
        p5.Vector.add(this.end, direction)
      );
    };
  }
}
