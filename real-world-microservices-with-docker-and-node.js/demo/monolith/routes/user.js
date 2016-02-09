var express = require('express');
var router = express.Router();
var uuid = require('uuid');

var users = [
	{ id: uuid.v4(), username: 'rschultz', firstName: 'Robert', lastName: 'Schultz' },
  	{ id: uuid.v4(), username: 'jdoe', firstName: 'John', lastName: 'Doe' }
];

router.get('/', function(req, res) {
  	res.json(users);
});

router.get('/:id', function(req, res) {
  	res.json(users[0]);
});

router.post('/', function(req, res) {
	users.push({ id: uuid.v4(), username: req.body.username, firstName: req.body.firstName, lastName: req.body.lastName });
  	res.json(users);
});

module.exports = router;
