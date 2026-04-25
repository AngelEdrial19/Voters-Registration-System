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

    const sql = "SELECT * FROM users WHERE username=? AND password=?";
    db.query(sql, [username, password], (err, result) => {
        if (err) return res.status(500).send(err);

        if (result.length > 0) {
            res.json({ success: true, user: result[0] });
        } else {
            res.json({ success: false, message: "Invalid credentials" });
        }
    });
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
    const { firstname, lastname, address, age, birthdate, gender, precinct_id } = req.body;

    const sql = `
        INSERT INTO voters 
        (firstname, lastname, address, age, birthdate, gender, precinct_id)
        VALUES (?, ?, ?, ?, ?, ?, ?)
    `;

    db.query(sql, [firstname, lastname, address, age, birthdate, gender, precinct_id],
        (err, result) => {
            if (err) return res.status(500).send(err);
            res.json({ message: "Voter added successfully" });
        });
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

    const sql = "INSERT INTO users (username, password) VALUES (?, ?)";
    db.query(sql, [username, password], (err, result) => {
        if (err) return res.status(500).send(err);

        res.json({ success: true, message: "Account created successfully" });
    });
});
app.get('/api/test-register', (req, res) => {
    res.json({ message: "Register route working" });
});