var express = require('express');
var request = require('request');
var router = express.Router();
var uuid = require('uuid');
var _ = require('lodash');

var cemeteries = [
	{ id: uuid.v4(), name: 'Golden Memorial', created: 'rschultz' },
  	{ id: uuid.v4(), name: 'Belmont Memorial', created: 'jdavis' }
];

router.get('/', function(req, res) {
	res.json(cemeteries);
});

router.get('/:id', function(req, res) {
  	res.json(cemeteries[0]);
});

router.post('/', function(req, res) {
	cemeteries.push({ id: uuid.v4(), name: req.body.name, created: req.body.created });
  	res.json(cemeteries);
});

module.exports = router;
