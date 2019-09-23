const cacheName = 'v2';
const resourceToPrecache = [
    '/',
    '/favicon.ico',
    '/css/site.css',
    '/lib/bootstrap/dist/css/bootstrap.css',
    'https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css',
    '/img/logo.jpg',
    '/img/topo.jpg',
    '/img/fiap.png'
];

self.addEventListener('install', (event) => {
    event.waitUntil(
        caches.open(cacheName)
            .then(cache => cache.addAll(resourceToPrecache))
    );
});

self.addEventListener('fetch', (event) => {
    event.respondWith(
        caches.match(event.request)
            .then(cacheResponse => cacheResponse || fetch(event.request))
    );
});