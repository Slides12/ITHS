use ("myDb")

db.myCollection.find({ Weight: { $exists: true}});

db.myCollection.countDocuments({ Weight: { $exists: true}});


// db.myCollection.updateMany(
//     {productName: "Laptop"},
//     {$set: { color: "Pink"}}
// ); // CHanges the prop

// db.myCollection.updateOne(
//     {productName: "Laptop"},
//     {$unset: { color: ""}}
// ); //Remove the prop

// db.myCollection.updateOne(
//     {weight: { $exists: true}},
//     {$rename: { weight: "Weight"}}
// ); // Renames the prop

// db.myCollection.updateMany(
//     {weight: { $exists: true}},
//     {$mul: { weight: 2}}
// ); // Multiply by 2

// db.myCollection.updateOne(
//     {weight: 0},
//     {$unset: { weight: ""}}
// ); // Multiply by 2
