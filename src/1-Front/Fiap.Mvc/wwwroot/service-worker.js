const cacheName = 'v24';
const resourceToPrecache = [
    '/',
    '/favicon.ico',
    '/css/site.css',
    '/lib/bootstrap/dist/css/bootstrap.css',
    '/img/logo.jpg',
    '/img/topo.jpg',
    '/img/fiap.png'
];

self.addEventListener('install', (event) => {

    // Força a instalação do service worker
    self.skipWaiting();

    // Adiciona os arquivos no cache
    event.waitUntil(
        caches.open(cacheName)
            .then(cache => cache.addAll(resourceToPrecache))
    );
});

self.addEventListener('activate', (event) => {

    // Permitir a atualização do novo service worker
    self.clients.claim();

    // Limpa o cache
    event.waitUntil(
        caches.keys()
            .then(function (cacheKeys) {
                var deletePromisses = [];
                for (var i = 0; i < cacheKeys.length; i++) {
                    if (cacheKeys[i] !== cacheName) {
                        deletePromisses.push(caches.delete(cacheKeys[i]));
                    }
                }

                return Promisse.all(deletePromisses);
            })
    );
});

self.addEventListener('fetch', (event) => {
    event.respondWith(
        caches.match(event.request)
            .then(cacheResponse => cacheResponse || fetch(event.request))
    );
});