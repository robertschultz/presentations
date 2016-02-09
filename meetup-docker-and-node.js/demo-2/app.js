'use strict';

const http = require('http');
const redis = require('redis');

const hostname = '127.0.0.1';
const port = 3000;

//console.log(process.env.REDIS_PORT_5432_TCP_ADDR);
let client = redis.createClient(6379, 'redis');

http.createServer((req, res) => {
  client.incr("visit", redis.print);
  res.writeHead(200, { 'Content-Type': 'text/plain' });
  res.end('Hello World\n');
}).listen(port, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});
