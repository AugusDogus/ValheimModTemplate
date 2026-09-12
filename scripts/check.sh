#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")/.."

# Add game-independent behavior and compatibility checks as the mod grows.
bun run scripts/validate-package.ts
