const express = require('express');
const mysql = require('mysql2');
const cors = require('cors');

const swaggerUi = require('swagger-ui-express');
const swaggerDocument = require('./swagger.json');

const app = express();
app.use(cors());
app.use(express.json());


// =========================
// ✅ MySQL CONNECTION
// =========================
const db = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "",
    database: "voters_system"
});

db.connect(err => {
    if (err) {
        console.error("❌ MySQL Error:", err);
        return;
    }
    console.log("✅ Connected to MySQL");
});


// =========================
// ✅ SWAGGER UI (FIXED)
// =========================
app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerDocument));


// =========================
// 🔥 TEST ROUTE
// =========================
app.get('/test', (req, res) => {
    res.send("API WORKING");
});


// =========================
// 🔐 LOGIN
// =========================
app.post('/api/login', (req, res) => {
    const { username, password } = req.body;

    db.query(
        "SELECT * FROM users WHERE username=? AND password=?",
        [username, password],
        (err, result) => {
            if (err) return res.status(500).send(err);

            if (result.length > 0) {
                res.json({
                    success: true,
                    user_id: result[0].user_id, // 🔥 IMPORTANT
                    username: result[0].username
                });
            } else {
                res.json({ success: false });
            }
        }
    );
});


// =========================
// 🧑‍🗳️ GET ALL VOTERS
// =========================
app.get('/api/voters', (req, res) => {
    const sql = `
        SELECT v.*, p.precinct_no 
        FROM voters v
        JOIN precincts p ON v.precinct_id = p.precinct_id
    `;

    db.query(sql, (err, result) => {
        if (err) return res.status(500).send(err);
        res.json(result);
    });
});


// =========================
// ➕ ADD VOTER
// =========================
app.post('/api/voters', (req, res) => {
  const { firstname, lastname, address, age, birthdate, gender, precinct_id, user_id } = req.body;

  const sql = `
    INSERT INTO voters
    (firstname, lastname, address, age, birthdate, gender, precinct_id, status, user_id)
    VALUES (?, ?, ?, ?, ?, ?, ?, 'pending', ?)
  `;

  db.query(sql, [firstname, lastname, address, age, birthdate, gender, precinct_id, user_id],
    (err) => {
      if (err) return res.status(500).send(err);
      res.json({ success: true });
    }
  );
});

// =========================
// ✏️ UPDATE VOTER
// =========================
app.put('/api/voters/:id', (req, res) => {
    const id = req.params.id;
    const { firstname, lastname, address, age, birthdate, gender, precinct_id } = req.body;

    const sql = `
        UPDATE voters SET
        firstname=?, lastname=?, address=?, age=?, birthdate=?, gender=?, precinct_id=?
        WHERE voter_id=?
    `;

    db.query(sql,
        [firstname, lastname, address, age, birthdate, gender, precinct_id, id],
        (err, result) => {
            if (err) return res.status(500).send(err);
            res.json({ message: "Voter updated successfully" });
        });
});


// =========================
// ❌ DELETE VOTER
// =========================
app.delete('/api/voters/:id', (req, res) => {
    const id = req.params.id;

    db.query("DELETE FROM voters WHERE voter_id=?", [id], (err, result) => {
        if (err) return res.status(500).send(err);
        res.json({ message: "Voter deleted successfully" });
    });
});


// =========================
// 📍 GET PRECINCTS
// =========================
app.get('/api/precincts', (req, res) => {
    db.query("SELECT * FROM precincts", (err, result) => {
        if (err) return res.status(500).send(err);
        res.json(result);
    });
});


// =========================
// 🚀 START SERVER
// =========================
app.listen(3000, () => {
    console.log("🚀 Server running on http://localhost:3000");
});

// =========================
// 📝 REGISTER USER
// =========================
app.post('/api/register', (req, res) => {
    const { username, password } = req.body;

    db.query(
        "INSERT INTO users (username, password) VALUES (?, ?)",
        [username, password],
        (err, result) => {
            if (err) return res.status(500).send(err);
            res.json({ success: true });
        }
    );
});
app.get('/api/test-register', (req, res) => {
    res.json({ message: "Register route working" });
});


// GET approved voters (LIST OF VOTERS)
app.get('/api/voters', (req, res) => {
    const sql = `
        SELECT v.*, p.precinct_no
        FROM voters v
        JOIN precincts p ON v.precinct_id = p.precinct_id
        WHERE v.status = 'approved'
        ORDER BY v.voter_id DESC
    `;

    db.query(sql, (err, result) => {
        if (err) return res.status(500).send(err);
        res.json(result);
    });
});


//==============================
//      GET PENDING VOTERS
//==============================
app.get('/api/voters/pending', (req, res) => {
    const sql = `
        SELECT v.*, p.precinct_no 
        FROM voters v
        JOIN precincts p ON v.precinct_id = p.precinct_id
        WHERE v.status = 'pending'
        ORDER BY v.voter_id DESC
    `;

    db.query(sql, (err, result) => {
        if (err) return res.status(500).send(err);
        res.json(result);
    });
});


//================================
//       ACCEPT VOTERS
//================================
app.put('/api/voters/accept/:id', (req, res) => {
    const id = req.params.id;

    db.query("UPDATE voters SET status='approved' WHERE voter_id=?", [id], (err) => {
        if (err) return res.status(500).send(err);
        res.json({ success: true });
    });
});

//================================
//       REJECT VOTERS
//================================
app.put('/api/voters/reject/:id', (req, res) => {
    const id = req.params.id;

    console.log("Rejecting ID:", id); // 🔥


    db.query(
        "UPDATE voters SET status='rejected' WHERE voter_id=?",
        [id],
        (err, result) => {
            if (err) {
                console.log(err);
                return res.status(500).send(err);
            }

            console.log("Affected rows:", result.affectedRows);

            if (result.affectedRows === 0) {
                return res.json({ success: false, message: "No record updated" });
            }

            res.json({ success: true });
        }
    );
});