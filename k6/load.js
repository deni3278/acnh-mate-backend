import http from 'k6/http'
import { htmlReport } from "https://raw.githubusercontent.com/benc-uk/k6-reporter/main/dist/bundle.js";

export const options = {
    thresholds: {
      http_req_duration: ['p(99)<200']
    },
    duration: "10s",
    vus: 10
}

export default function() {
    http.get(__ENV.BASE_URL + '/api/art')
}

export function handleSummary(data) {
    return {
        'backend/k6/load.html': htmlReport(data)
    }
}